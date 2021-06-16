using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Songs_Manager.Data.Models;
using Songs_Manager.Data.Services;
using Songs_Manager.Data.ViewModels;
using Songs_Manager.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Controllers.Admin
{
    public class ArtistController : Controller
    {
        private readonly ArtistService _artistService;
        private readonly GenreService _genreService;

        public ArtistController(ArtistService artistService, GenreService genreService)
        {
            _artistService = artistService;
            _genreService = genreService;
        }

        [TempData]
        public string Error { get; set; }
        [TempData]
        public string Message { get; set; }

        // GET: ArtistController
        [Route("/admin/artists")]
        public ActionResult Index()
        {
            List<ArtistWithSongsVM> allArtists = _artistService.GetAllArtistsWithSongs();
            return View("/Views/Admin/Artist/Index.cshtml", allArtists);
        }

        // GET: ArtistController/Show/5
        [Route("/admin/artists/{id}")]
        public ActionResult Show(int id)
        {
            ArtistVM artist = _artistService.GetArtist(id);
            return View("/Views/Admin/Artist/Show.cshtml", artist);
        }

        // GET: ArtistController/Create
        [Route("/admin/artists/create")]
        public ActionResult Create()
        {
            //List<SelectListItem> Genres = new List<SelectListItem>();
            //foreach (var genre in _genreService.GetGenres())
            //{
            //    Genres.Add(new SelectListItem() { Text = genre.Name, Value = genre.GenreId.ToString() });
            //}
            //ViewBag.Genres = Genres;

            PopulateGenresDropDownList();
            return View("/Views/Admin/Artist/Create.cshtml", new ArtistCreateVM());
        }

        // POST: ArtistController/Create
        [HttpPost("/admin/artists/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([FromForm] ArtistCreateVM artist)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _artistService.CreateArtist(artist);

                    if (result > 0)
                    {
                        Message = "Succesfully.";
                        return RedirectToAction(nameof(Index));
                    }
                }
                Error = "Error";
                Message = "Something went wrong.";
                PopulateGenresDropDownList(artist.Genres);
                return View("/Views/Admin/Artist/Create.cshtml", artist);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View("/Views/Admin/Artist/Create.cshtml", artist);
            }

        }

        // GET: ArtistController/Edit/5
        [Route("/admin/artists/{id}/edit")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var artist = _artistService.GetArtist(id);
            if (artist == null)
            {
                return NotFound();
            }
            List<int> genres = new List<int>();
            foreach (var genre in artist.Genres)
            {
                genres.Add(genre.GenreId);
            }
            var _artist = new ArtistEditVM()
            {
                ArtistId = artist.ArtistId,
                Name = artist.Name,
                Slug = artist.Slug,
                Country = artist.Country,
                Bio = artist.Bio,
                Genres = genres,
            };
            PopulateGenresDropDownList(artist.Genres);
            return View("/Views/Admin/Artist/Edit.cshtml", _artist);
        }

        // POST: ArtistController/Edit/5
        [HttpPost("/admin/artists/{id}/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id, [FromForm] ArtistEditVM artist)
        {
            try
            {
                if (id != artist.ArtistId)
                {
                    return NotFound();
                }
                var result = await _artistService.UpdateArtist(artist);

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
            PopulateGenresDropDownList(artist.Genres);
            return View("/Views/Admin/Artist/Edit.cshtml", artist);
        }

        // GET: ArtistController/Delete/5
        //[Route("/admin/artists/{id}/delete")]
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: ArtistController/Delete/5
        [HttpPost("/admin/artists/{id}/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                if(id == 0)
                {
                    return NotFound();
                }
                
                var result = await _artistService.DeleteArtist(id);

                if (result.isSuccess > 0)
                {
                    Message = "Succesfully deleted artist with name "  + result.name + ".";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View();
            }

            Error = "Error";
            Message = "Something went wrong.";
            return RedirectToAction(nameof(Index));
        }

        private void PopulateGenresDropDownList(object selectedGenre = null)
        {
            ViewBag.Genres = new SelectList(_genreService.GetGenres(), "GenreId", "Name", selectedGenre);
        }
    }
}
