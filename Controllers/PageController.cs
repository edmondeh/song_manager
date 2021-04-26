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

        public PageController(ArtistService artistService)
        {
            _artistService = artistService;
        }

        public IActionResult Index()
        {
            List<TopTenArtists> topTenArtists = _artistService.GetTopTenArtists();
            return View(topTenArtists);
        }
    }
}