using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Songs_Manager.Data.Services;
using Songs_Manager.Data.ViewModels;

namespace Songs_Manager.Controllers
{
    public class PageController : Controller
    {
        private ArtistService _artistService;
        private SongService _songService;

        public PageController(ArtistService artistService, SongService songService)
        {
            _artistService = artistService;
            _songService = songService;
        }

        public IActionResult Index()
        {
            //List<TopTenArtists> topTenArtists = _artistService.GetTopTenArtists();
            //List<SongVM> recentlySongs = _songService.GetSongs().Result;
            var model = new IndexVM {
                TopTenArtists = _artistService.GetTopTenArtists(),
                RecentlySongs = _songService.GetSongs().Result
            };
            return View(model);
        }
    }
}