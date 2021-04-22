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
    }
}
