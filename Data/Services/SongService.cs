using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Songs_Manager.Data.Models;
using Songs_Manager.Data.ViewModels;
using Songs_Manager.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Services
{
    public class SongService
    {
        private ApplicationDbContext _context;

        public SongService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<SongVM>> GetSongs(int? pageNumber = null)
        {
            //var songs = from s in _context.Songs
            //               select s;
            var _songs = _context.Songs.Select(s => new SongVM()
            {
                SongId = s.SongId,
                Name = s.Name,
                Slug = s.Slug,
                Album = s.Album,
                Artists = s.Artist_Songs.Select(a => a.Artists).ToList()
            }).OrderByDescending(s => s.SongId);

            int pageSize = 10;
            return await PaginatedList<SongVM>.CreateAsync(_songs.AsNoTracking(), pageNumber ?? 1, pageSize);

            //var _songs = _context.Songs.Select(s => new SongVM()
            //{
            //    SongId = s.SongId,
            //    Name = s.Name,
            //    Slug = s.Slug,
            //    Album = s.Album,
            //    Artists = s.Artist_Songs.Select(a => a.Artists).ToList()
            //}).OrderByDescending(s => s.SongId).ToList();

            //return _songs;
        }

        public async Task<List<Song>> GetAllSongs()
        {
            try
            {
                var _songs = await _context.Songs.Include(s => s.Artist_Songs)
                                                    .ThenInclude(a => a.Artists)
                                            .Include(s => s.Song_Genres)
                                                .ThenInclude(g => g.Genre)
                                            .OrderByDescending(s => s.SongId)
                                            .ToListAsync();
                if (_songs != null)
                {
                    return _songs;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new List<Song>();
        }

        public List<FeaturedSongsVM> GetFeaturedSongs()
        {
            var _topSongs = _context.Songs.Select(s => new FeaturedSongsVM()
            {
                Name = s.Name,
                Slug = s.Slug,
                Featured = s.Featured,
                Album = s.Album,
                Artists = s.Artist_Songs.Select(a => a.Artists).ToList()
            }).Where(s => s.Featured == true).OrderBy(s => Guid.NewGuid()).Take(6).ToList();

            return _topSongs;
        }

        public List<TopSongs> GetTopSongs()
        {
            var _topSongs = _context.Songs.Select(s => new TopSongs()
            {
                Name = s.Name,
                Slug = s.Slug,
                Album = s.Album,
                Artists = s.Artist_Songs.Select(a => a.Artists).ToList()
            }).Take(10).ToList();

            return _topSongs;
        }

        public SongWithArtistVM GetTopSongsInArtist(string slug)
        {
            var _song = _context.Songs.Select(s => new SongWithArtistVM()
            {
                Name = s.Name,
                Slug = s.Slug,
                Artist = s.Artist_Songs.Select(a => new ArtistWithSongsVM()
                {
                    Name = a.Artists.Name,
                    Slug = a.Artists.Slug,
                    Country = a.Artists.Country,
                    Bio = a.Artists.Bio,
                    Songs = a.Artists.Artist_Songs.Select(a => a.Songs).OrderByDescending(s => s.SongId).Take(10).ToList()
                }).ToList()
            }).Where(s => s.Slug == slug).FirstOrDefault();

            //var _artistWithTopSongs = _context.Artists.Select(s => new ArtistWithSongs()
            //{
            //    Name = s.Name,
            //    Slug = s.Slug,
            //    Country = s.Country,
            //    Bio = s.Bio,
            //    Songs = s.Artist_Songs.Select(a => a.Songs).OrderByDescending(s => s.SongId).Take(10).ToList()
            //}).FirstOrDefault();

            return _song;
        }

        public SongShowVM GetSong(string slug)
        {
            var _topSongs = _context.Songs.Select(s => new SongShowVM()
            {
                Name = s.Name,
                Slug = s.Slug,
                Lyrics = s.Lyrics,
                Album = s.Album,
                Artists = s.Artist_Songs.Select(a => a.Artists).ToList()
            }).Where(s => s.Slug == slug).FirstOrDefault();

            return _topSongs;
        }

        public SongShowVM GetSong(int id)
        {
            var _songShow = _context.Songs.Select(s => new SongShowVM()
            {
                SongId = s.SongId,
                Name = s.Name,
                Slug = s.Slug,
                Lyrics = s.Lyrics,
                Album = s.Album,
                UserName = s.UserName,
                CreatedAt = s.CreatedAt,
                LastUpdatedAt = s.LastUpdatedAt,
                Artists = s.Artist_Songs.Select(a => a.Artists).ToList(),
                Genres = s.Song_Genres.Select(s => s.Genre).ToList()
            }).FirstOrDefault(s => s.SongId == id);

            return _songShow;
        }

        public async Task<int> CreateSong(SongCreateVM song)
        {
            try
            {
                var _song = new Song()
                {
                    Name = UpperCase(song.Name),
                    Slug = StringExtensions.Slugify(UpperCase(song.Name)),
                    Album = UpperCase(song.Album),
                    Lyrics = song.Lyrics,
                    UserName = UpperCase(song.UserName),
                };
                await _context.Songs.AddAsync(_song);
                await _context.SaveChangesAsync();

                foreach (var id in song.Artists)
                {
                    var _artist_song = new Artist_Song()
                    {
                        ArtistId = id,
                        SongId = _song.SongId
                    };
                    await _context.Artist_Songs.AddAsync(_artist_song);
                    await _context.SaveChangesAsync();
                }

                foreach (var id in song.Genres)
                {
                    var _song_genre = new Song_Genre()
                    {
                        SongId = _song.SongId,
                        GenreId = id
                    };
                    await _context.Song_Genres.AddAsync(_song_genre);
                    await _context.SaveChangesAsync();
                }

                return _song.SongId;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return song.SongId;
        }

        public async Task<int> UpdateSong(SongEditVM song)
        {
            try
            {
                var _song = await _context.Songs.Include(s => s.Artist_Songs)
                                        .Include(s => s.Song_Genres)
                                        .FirstOrDefaultAsync(s => s.SongId == song.SongId);
                if (_song != null)
                {
                    _song.Name = UpperCase(song.Name);
                    _song.Slug = StringExtensions.Slugify(UpperCase(song.Name));
                    _song.Album = UpperCase(song.Album);
                    _song.Lyrics = song.Lyrics;
                    _song.UserName = UpperCase(song.UserName);
                    _song.Artist_Songs.Clear();
                    _song.Song_Genres.Clear();

                    foreach (var id in song.Artists)
                    {
                        var _artists_song = new Artist_Song()
                        {
                            SongId = _song.SongId,
                            ArtistId = id
                        };
                        await _context.Artist_Songs.AddAsync(_artists_song);
                        await _context.SaveChangesAsync();
                    }
                    foreach (var id in song.Genres)
                    {
                        var _song_genres = new Song_Genre()
                        {
                            SongId = _song.SongId,
                            GenreId = id
                        };
                        await _context.Song_Genres.AddAsync(_song_genres);
                        await _context.SaveChangesAsync();
                    }
                    await _context.SaveChangesAsync();
                }

                return _song.SongId;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }

        public async Task<(int isSuccess, string name)> DeleteSong(int id)
        {
            string name = "!";
            try
            {
                var _song = await _context.Songs.FirstOrDefaultAsync(s => s.SongId == id);
                if (_song != null)
                {
                    _context.Songs.Remove(_song);
                    await _context.SaveChangesAsync();
                }
                return (id, _song.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return (0, name);
        }

        public static string UpperCase(string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }
    }
}
