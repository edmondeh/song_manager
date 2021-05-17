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
        private GenreService _genreService;

        public PageController(ArtistService artistService,
                            SongService songService, 
                            GenreService genreService)
        {
            _artistService = artistService;
            _songService = songService;
            _genreService = genreService;
        }

        public ActionResult Index()
        {
            //List<TopTenArtists> topTenArtists = _artistService.GetTopTenArtists();
            //List<SongVM> recentlySongs = _songService.GetSongs().Result;
            var model = new IndexVM {
                TopTenArtists = _artistService.GetTopTenArtists(),
                FeaturedSongs = _songService.GetFeaturedSongs(),
                RecentlySongs = _songService.GetSongs().Result
            };
            return View(model);
        }

        [Route("/about-us")]
        public ActionResult AboutUs()
        {
            return View();
        }

        [Route("/our-vision")]
        public ActionResult OurVision()
        {
            return View();
        }

        [Route("/privacy")]
        public ActionResult Privacy()
        {
            return View();
        }

        [Route("/term-conditions")]
        public ActionResult TermAndConditions()
        {
            return View();
        }

        [Route("/feed")]
        public ActionResult Feed()
        {
            return View();
        }

        [Route("/sitemap")]
        public ActionResult Sitemap()
        {
            return View();
        }
    }
}