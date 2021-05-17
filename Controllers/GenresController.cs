using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Songs_Manager.Data.Services;

namespace Songs_Manager.Controllers
{
    public class GenresController : Controller
    {
        private readonly GenreService _genreService;

        public GenresController(GenreService genreService)
        {
            _genreService = genreService;
        }

        [Route("genres/{slug}")]
        public ActionResult Index(string slug)
        {
            var _genre = _genreService.GetGenreWithSongs(slug);
            return View(_genre);
        }
    }
}