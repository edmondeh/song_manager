using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Models
{
    public class Artist_Song
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public Artist Artists { get; set; }
        public int SongId { get; set; }
        public Song Songs { get; set; }
    }
}
