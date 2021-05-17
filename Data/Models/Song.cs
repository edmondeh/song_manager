using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Models
{
    public class Song : ITrackable
    {
        public int SongId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        public bool Featured { get; set; }
        public string Album { get; set; }
        [Required]
        public string Lyrics { get; set; }
        public string UserName { get; set; }
        public List<Artist_Song> Artist_Songs { get; set; }
        public List<Song_Genre> Song_Genres { get; set; }

        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public string LastUpdatedBy { get; set; }
    }
}
