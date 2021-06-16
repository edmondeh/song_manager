using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Models
{
    public class LyricsSubmissions : ITrackable
    {
        public int LyricsSubmissionsId { get; set; }
        public string Type { get; set; }
        public string NickName { get; set; }
        public string Artist { get; set; }
        public string Song { get; set; }
        public string Album { get; set; }
        public string From { get; set; }
        public string Lyrics { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
