using Songs_Manager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.ViewModels
{
    public class SearchVM
    {
        public List<SongShowVM> Songs { get; set; }
        public List<ArtistWithSongsVM> Artists { get; set; }
        public string SearchString { get; set; }
    }
}
