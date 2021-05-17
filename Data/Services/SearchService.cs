using Microsoft.EntityFrameworkCore;
using Songs_Manager.Data.Models;
using Songs_Manager.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Services
{
    public class SearchService
    {
        private ApplicationDbContext _context;

        public SearchService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SongShowVM>> SearchForSongs(string searchString)
        {
            //var _songs = from s in _context.Songs
            //             select s;

            List<SongShowVM> _songs = new List<SongShowVM>();

            if (!String.IsNullOrEmpty(searchString))
            {
                _songs = await _context.Songs.Select(s => new SongShowVM
                {
                    Name = s.Name,
                    Slug = s.Slug,
                    Lyrics = s.Lyrics,
                    Album = s.Album,
                    Artists = s.Artist_Songs.Select(a => a.Artists).ToList()
                }).Where(s => s.Name.Contains(searchString)
                    || s.Lyrics.Contains(searchString)
                    || s.Album.Contains(searchString)).ToListAsync();
            }

            return _songs;
        }

        public async Task<List<ArtistWithSongsVM>> SearchForArtists(string searchString)
        {
            //var _artists = from a in _context.Artists
            //             select a;

            List<ArtistWithSongsVM> _artist = new List<ArtistWithSongsVM>();

            if (!String.IsNullOrEmpty(searchString))
            {
                _artist = await _context.Artists.Select(a => new ArtistWithSongsVM
                {
                    Name = a.Name,
                    Slug = a.Slug,
                    Country = a.Country,
                    Bio = a.Bio,
                    Songs = a.Artist_Songs.Select(s => s.Songs).ToList()
                }).Where(a => a.Name.Contains(searchString)
                    || a.Bio.Contains(searchString))
                    .ToListAsync();
            }

            return _artist;
        }
    }
}
