using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        public string Country { get; set; }
        public string Bio { get; set; }
        public List<Artist_Song> Artist_Songs { get; set; }

    }
}
