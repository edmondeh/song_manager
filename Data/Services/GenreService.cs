using Microsoft.EntityFrameworkCore;
using Songs_Manager.Data.Models;
using Songs_Manager.Data.ViewModels;
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

        public List<Genre> GetGenres()
        {
            var _genres = _context.Genres.ToList();

            return _genres;
        }

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
    }
}
