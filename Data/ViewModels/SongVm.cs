using Songs_Manager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.ViewModels
{
    public class SongVM
    {
        public int SongId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Album { get; set; }
        public List<Artist> Artists { get; set; }
    }

    public class TopSongs
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Album { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
