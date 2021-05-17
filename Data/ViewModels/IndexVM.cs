using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.ViewModels
{
    public class IndexVM
    {
        public List<TopTenArtists> TopTenArtists { get; set; }
        public List<SongVM> RecentlySongs { get; set; }
        public List<FeaturedSongsVM> FeaturedSongs { get; set; }
    }
}
