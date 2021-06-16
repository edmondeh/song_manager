using Microsoft.EntityFrameworkCore;
using Songs_Manager.Data.Models;
using Songs_Manager.Data.ViewModels;
using Songs_Manager.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Services
{
    public class GenreService
    {
        private ApplicationDbContext _context;

        public GenreService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Genre GetGenre(int id)
        {
            var _genre = _context.Genres.FirstOrDefault(g => g.GenreId == id);

            return _genre;
        }

        public List<Genre> GetGenres() =>_context.Genres.OrderByDescending(g => g.GenreId).ToList();

        public GenreVM GetGenreWithSongs(string slug)
        {
            var _genresWithSongs = _context.Genres.Select(g => new GenreVM()
            {
                Name = g.Name,
                Slug = g.Slug,
                Info = g.Info,
                Songs = g.Song_Genres.Select(s => new SongsInGenres() {
                    Name = s.Song.Name,
                    Slug = s.Song.Slug,
                    Album = s.Song.Album,
                    Artists = s.Song.Artist_Songs.Select(a => a.Artists)
                }).ToList()
            }).Where(s => s.Slug == slug).FirstOrDefault();

            return _genresWithSongs;
        }

        public async Task<int> CreateGenre(GenreCreateVM genre)
        {
            try
            {
                var _genre = new Genre()
                {
                    Name = SongService.UpperCase(genre.Name),
                    Slug = StringExtensions.Slugify(genre.Name),
                    Info = SongService.UpperCase(genre.Info)
                };
                await _context.Genres.AddAsync(_genre);
                await _context.SaveChangesAsync();

                return _genre.GenreId;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }

        public async Task<int> UpdateGenre(GenreEditVM genre)
        {
            try
            {
                var _genre = await _context.Genres.FirstOrDefaultAsync(g => g.GenreId == genre.GenreId);

                if (_genre != null)
                {
                    _genre.Name = SongService.UpperCase(genre.Name);
                    _genre.Slug = genre.Slug != null ? StringExtensions.Slugify(genre.Slug) : StringExtensions.Slugify(genre.Name);
                    _genre.Info = genre.Info;

                    await _context.SaveChangesAsync();
                }

                return _genre.GenreId;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }

        public async Task<(int isSuccess, string name)> DeleteGenre(int id)
        {
            string name = "!";
            try
            {
                var _genre = await _context.Genres.FirstOrDefaultAsync(g => g.GenreId == id);
                if (_genre != null)
                {
                    _context.Genres.Remove(_genre);
                    await _context.SaveChangesAsync();
                }
                return (id, _genre.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return (0, name);
        }
    }
}
