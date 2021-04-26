using Songs_Manager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.ViewModels
{
    public class ArtistVM
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Country { get; set; }
        public string Bio { get; set; }
    }

    public class ArtistWithSongs
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Country { get; set; }
        public string Bio { get; set; }
        public List<Song> Songs { get; set; }
    }

    public class TopTenArtists
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
