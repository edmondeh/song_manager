using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Songs_Manager.Data.Models;
using Songs_Manager.Data.ViewModels;
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

        public async Task<List<SongVM>> GetSongs(int? pageNumber = null)
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
    }
}
