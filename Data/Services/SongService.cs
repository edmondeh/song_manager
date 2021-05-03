﻿using Microsoft.EntityFrameworkCore;
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
    }
}
