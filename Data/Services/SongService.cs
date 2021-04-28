using Songs_Manager.Data.Models;
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

        public List<Song> GetTopSongs()
        {
            var _topSongs = _context.Songs.Take(10).ToList();

            return _topSongs;
        }
    }
}
