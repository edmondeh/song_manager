using Microsoft.EntityFrameworkCore;
using Songs_Manager.Data.Models;
using Songs_Manager.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Services
{
    public class ArtistService
    {
        private ApplicationDbContext _context;

        public ArtistService(ApplicationDbContext context)
        {
            _context = context;
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

        public List<ArtistWithSongs> GetAllArtistsWithSongs()
        {
            var _artistWithSongs = _context.Artists.Select(artist => new ArtistWithSongs()
            {
                Name = artist.Name,
                Slug = artist.Slug,
                Country = artist.Country,
                Bio = artist.Bio,
                Songs = artist.Artist_Songs.Select(n => n.Songs).ToList()
            }).ToList();

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
    }
}
