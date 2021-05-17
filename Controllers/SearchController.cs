using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Songs_Manager.Data.Services;
using Songs_Manager.Data.ViewModels;

namespace Songs_Manager.Controllers
{
    public class SearchController : Controller
    {
        private readonly SearchService _searchService;
        public SearchController(SearchService searchService)
        {
            _searchService = searchService;
        }
        // POST: Search
        [HttpPost]
        public ActionResult Index(string SearchString)
        {
            //var query = HttpContext.Request.Form["searchString"];
            var model = new SearchVM
            {
                Songs = _searchService.SearchForSongs(SearchString).Result,
                Artists = _searchService.SearchForArtists(SearchString).Result,
                SearchString = SearchString
            };
            return View(model);
        }
    }
}