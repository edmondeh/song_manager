using Songs_Manager.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.ViewModels
{
    public class GenreVM
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Info { get; set; }
        public List<SongsInGenres> Songs { get; set; }
    }

    public class SongsInGenres
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Album { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
    }

    public class GenreSelectList
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
    }

    public class GenreCreateVM
    {
        public int GenreId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        [Required]
        public string Info { get; set; }
    }

    public class GenreEditVM
    {
        [Required]
        public int GenreId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        [Required]
        public string Info { get; set; }
    }
}
