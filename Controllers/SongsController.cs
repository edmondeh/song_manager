using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Songs_Manager.Data.Models;
using Songs_Manager.Data.Services;
using Songs_Manager.Data.ViewModels;

namespace Songs_Manager.Controllers
{
    public class SongsController : Controller
    {
        private readonly SongService _songService;

        public SongsController(SongService songService)
        {
            _songService = songService;
        }

        // GET: songs
        public ActionResult Index(int? pageNumber)
        {
            List<SongVM> songs = _songService.GetSongs(pageNumber).Result;
            return View(songs);
        }

        // GET: top_songs
        [Route("~/top_songs")]
        public ActionResult Top_Songs()
        {
            List<TopSongs> songs = _songService.GetTopSongs();
            return View(songs);
        }

        // GET: songs/slug
        [Route("/songs/{slug}")]
        public ActionResult Show(string slug)
        {
            var model = new SongsVM
            {
                Song = _songService.GetSong(slug),
                TopSongsInArtist = _songService.GetTopSongsInArtist(slug)
            };
            return View(model);
        }
    }
}