using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Models
{
    public class Artist_Song : ITrackable
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public Artist Artists { get; set; }
        public int SongId { get; set; }
        public Song Songs { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
