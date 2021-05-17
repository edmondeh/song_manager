using Microsoft.AspNetCore.Mvc;
using Songs_Manager.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Views.ViewComponents
{
    public class GetGenresViewComponent : ViewComponent
    {
        private readonly GenreService _genreService;

        public GetGenresViewComponent(GenreService genreService)
        {
            _genreService = genreService;
        }

        public IViewComponentResult Invoke()
        {
            var _genres = _genreService.GetGenres();

            return View(_genres);
        }
    }
}
