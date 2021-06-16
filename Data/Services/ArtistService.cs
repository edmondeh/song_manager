using Microsoft.EntityFrameworkCore;
using Songs_Manager.Data.Models;
using Songs_Manager.Data.ViewModels;
using Songs_Manager.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Songs_Manager.Data.Services
{
    public class ArtistService
    {
        private ApplicationDbContext _context;

        public ArtistService(ApplicationDbContext context)
        {
            _context = context;
        }

        public ArtistVM GetArtist(int? id)
        {
            var _artist = _context.Artists.Select(artist => new ArtistVM()
            {
                ArtistId = artist.ArtistId,
                Name = artist.Name,
                Slug = artist.Slug,
                Country = artist.Country,
                Bio = artist.Bio,
                Songs = artist.Artist_Songs.Select(s => s.Songs).ToList(),
                Genres = artist.Artist_Genres.Select(s => s.Genres).ToList(),
                CreatedAt = artist.CreatedAt,
                LastUpdatedAt = artist.LastUpdatedAt
            }).Where(artist => artist.ArtistId == id).FirstOrDefault();

            return _artist;
        }

        public ArtistVM GetArtist(string slug)
        {
            var _artist = _context.Artists.Select(artist => new ArtistVM()
            {
                Name = artist.Name,
                Slug = artist.Slug,
                Country = artist.Country,
                Bio = artist.Bio,
                Songs = artist.Artist_Songs.Select(s => s.Songs).ToList(),
                Genres = artist.Artist_Genres.Select(s => s.Genres).ToList(),
            }).Where(artist => artist.Slug == slug).FirstOrDefault();

            return _artist;
        }

        public List<Artist> GetAllArtists() => _context.Artists.ToList();
        public async Task<List<Artist>> GetAllArtists(int? pageNumber)
        {
            var artists = _context.Artists;

            int pageSize = 10;
            return await PaginatedList<Artist>.CreateAsync(artists.AsNoTracking(), pageNumber ?? 1, pageSize);
        }

        public List<ArtistWithSongsVM> GetAllArtistsWithSongs()
        {
            var _artistWithSongs = _context.Artists.Select(artist => new ArtistWithSongsVM()
            {
                ArtistId = artist.ArtistId,
                Name = artist.Name,
                Slug = artist.Slug,
                Country = artist.Country,
                Bio = artist.Bio,
                Songs = artist.Artist_Songs.Select(n => n.Songs).ToList(),
                Genres = artist.Artist_Genres.Select(s => s.Genres).ToList(),
            }).OrderByDescending(a => a.ArtistId).ToList();

            return _artistWithSongs;
        }

        public List<TopTenArtists> GetTopTenArtists()
        {
            var _topTenArtists = _context.Artists.Select(artist => new TopTenArtists()
            {
                Name = artist.Name,
                Slug = artist.Slug
            }).ToList();

            return _topTenArtists;
        }

        public async Task<int> CreateArtist(ArtistCreateVM artist)
        {
            try
            {
                var _artist = new Artist()
                {
                    Name = artist.Name,
                    Slug = StringExtensions.Slugify(artist.Name),
                    Country = artist.Country,
                    Bio = artist.Bio
                };
                await _context.Artists.AddAsync(_artist);
                await _context.SaveChangesAsync();

                foreach (var id in artist.Genres)
                {
                    var _artist_genre = new Artist_Genre()
                    {
                        ArtistId = _artist.ArtistId,
                        GenreId = id
                    };
                    await _context.Artist_Genres.AddAsync(_artist_genre);
                    await _context.SaveChangesAsync();
                }

                return _artist.ArtistId;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return artist.ArtistId;
        }

        public async Task<int> UpdateArtist(ArtistEditVM artist)
        {
            try
            {
                var _artist = await _context.Artists.Include(a => a.Artist_Genres).FirstOrDefaultAsync(a => a.ArtistId == artist.ArtistId);
                if (_artist != null)
                {
                    _artist.Name = artist.Name;
                    _artist.Slug = _artist.Slug == artist.Slug ? _artist.Slug : StringExtensions.Slugify(artist.Name);
                    _artist.Country = artist.Country;
                    _artist.Bio = artist.Bio;
                    _artist.Artist_Genres.Clear();

                    foreach (var id in artist.Genres)
                    {
                        var _artist_genre = new Artist_Genre()
                        {
                            ArtistId = _artist.ArtistId,
                            GenreId = id
                        };
                        await _context.Artist_Genres.AddAsync(_artist_genre);
                        await _context.SaveChangesAsync();
                    }
                    await _context.SaveChangesAsync();
                }

                return _artist.ArtistId;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }

        public async Task<(int isSuccess, string name)> DeleteArtist(int id)
        {
            string name = "!";
            try
            {
                var _artist = await _context.Artists.FirstOrDefaultAsync(a => a.ArtistId == id);
                if (_artist != null)
                {
                    _context.Artists.Remove(_artist);
                    await _context.SaveChangesAsync();
                }
                return (id, _artist.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return (0, name);
        }
    }
}
