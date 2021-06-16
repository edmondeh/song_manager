using Songs_Manager.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.ViewModels
{
    public class ArtistVM
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Country { get; set; }
        public string Bio { get; set; }
        public List<Song> Songs { get; set; }
        public List<Genre> Genres { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }

    public class SongsInArtist
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class ArtistWithSongsVM
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Country { get; set; }
        public string Bio { get; set; }
        public List<Song> Songs { get; set; }
        public List<Genre> Genres { get; set; }
    }

    public class TopTenArtists
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }

    public class ArtistCreateVM
    {
        public int ArtistId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Bio { get; set; }
        public List<Song> Songs { get; set; }
        [Required]
        public int[] Genres { get; set; }
    }

    public class ArtistEditVM
    {
        [Required]
        public int ArtistId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Bio { get; set; }
        public List<Song> Songs { get; set; }
        [Required]
        public List<int> Genres { get; set; }
    }
}
