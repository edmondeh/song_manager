using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Songs_Manager.Data.Models;
using Songs_Manager.Data.Services;
using Songs_Manager.Data.ViewModels;

namespace Songs_Manager.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly ArtistService _artistService;

        public ArtistsController(ArtistService artistService)
        {
            _artistService = artistService;
        }

        // GET: Artists
        public ActionResult Index(int? pageNumber)
        {
            //String.IsNullOrEmpty(slug);
            var allArtists = _artistService.GetAllArtists(pageNumber).Result;
            return View(allArtists);
        }

        [Route("/artists/{slug}")]
        public ActionResult Show(string slug)
        {
            ArtistVM artist = _artistService.GetArtist(slug);
            //return Json(artist);
            return View(artist);
        }

    }
}