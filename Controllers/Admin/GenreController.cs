using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Songs_Manager.Data.Services;
using Songs_Manager.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Controllers.Admin
{
    public class GenreController : Controller
    {
        private readonly GenreService _genreService;

        public GenreController(GenreService genreService)
        {
            _genreService = genreService;
        }

        [TempData]
        public string Error { get; set; }
        [TempData]
        public string Message { get; set; }

        // GET: GenreController
        [Route("/admin/genres")]
        public ActionResult Index()
        {
            var genres = _genreService.GetGenres();
            return View("/Views/Admin/Genre/Index.cshtml", genres);
        }

        // GET: GenreController/Details/5
        [Route("/admin/genres/{id}")]
        public ActionResult Details(int id)
        {
            var genre = _genreService.GetGenre(id);
            return View("/Views/Admin/Genre/Show.cshtml", genre);
        }

        // GET: GenreController/Create
        [Route("/admin/genres/create")]
        public ActionResult Create()
        {
            return View("/Views/Admin/Genre/Create.cshtml", new GenreCreateVM());
        }

        // POST: GenreController/Create
        [HttpPost("/admin/genres/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([FromForm] GenreCreateVM genre)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _genreService.CreateGenre(genre);

                    if (result > 0)
                    {
                        Message = "Succesfully.";
                        return RedirectToAction(nameof(Index));
                    }
                }
                Error = "Error";
                Message = "Something went wrong.";
                return View("/Views/Admin/Genre/Create.cshtml", genre);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View("/Views/Admin/Genre/Create.cshtml", genre);
            }
        }

        // GET: GenreController/Edit/5
        [Route("/admin/genres/{id}/edit")]
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var genre = _genreService.GetGenre(id);
            if (genre == null)
            {
                return NotFound();
            }
            var _genre = new GenreEditVM()
            {
                GenreId = genre.GenreId,
                Name = genre.Name,
                Slug = genre.Slug,
                Info = genre.Info,
            };
            return View("/Views/Admin/Genre/Edit.cshtml", _genre);
        }

        // POST: GenreController/Edit/5
        [HttpPost("/admin/genres/{id}/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [FromForm] GenreEditVM genre)
        {
            try
            {
                if (id != genre.GenreId)
                {
                    return NotFound();
                }
                var result = await _genreService.UpdateGenre(genre);

                if (result > 0)
                {
                    Message = "Succesfully.";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Error = "Error";
            Message = "Something went wrong.";
            return View("/Views/Admin/Genre/Edit.cshtml", genre);
        }

        //// GET: GenreController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: GenreController/Delete/5
        [HttpPost("/admin/genres/{id}/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }

                var result = await _genreService.DeleteGenre(id);

                if (result.isSuccess > 0)
                {
                    Message = "Succesfully deleted genre with name " + result.name + ".";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                Error = "Error";
                Message = "Something went wrong.";
                return RedirectToAction(nameof(Index));
            }

            Error = "Error";
            Message = "Something went wrong.";
            return RedirectToAction(nameof(Index));
        }
    }
}
