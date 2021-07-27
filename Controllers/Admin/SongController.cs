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
    public class SongController : Controller
    {
        private readonly SongService _songService;
        private readonly GenreService _genreService;
        private readonly ArtistService _artistService;

        public SongController(SongService songService, 
                                GenreService genreService,
                                ArtistService artistService)
        {
            _songService = songService;
            _genreService = genreService;
            _artistService = artistService;
        }

        [TempData]
        public string Error { get; set; }
        [TempData]
        public string Message { get; set; }

        // GET: SongController
        [Route("/admin/songs")]
        public ActionResult Index()
        {
            var allSongs = _songService.GetAllSongs().Result;
            return View("/Views/Admin/Song/Index.cshtml", allSongs);
        }

        // GET: SongController/Show/5
        [Route("/admin/songs/{id}")]
        public ActionResult Show(int id)
        {
            var song = _songService.GetSong(id);
            return View("/Views/Admin/Song/Show.cshtml", song);
        }

        // GET: SongController/Create
        [Route("/admin/songs/create")]
        public ActionResult Create()
        {
            PopulateArtistsDropDownList();
            PopulateGenresDropDownList();
            return View("/Views/Admin/Song/Create.cshtml", new SongCreateVM());
        }

        // POST: SongController/Create
        [HttpPost("/admin/songs/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([FromForm] SongCreateVM song)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _songService.CreateSong(song);

                    if (result > 0)
                    {
                        Message = "Succesfully.";
                        return RedirectToAction(nameof(Index));
                    }
                }
                Error = "Error";
                Message = "Something went wrong.";
                PopulateArtistsDropDownList(song.Artists);
                PopulateGenresDropDownList(song.Genres);
                return View("/Views/Admin/Song/Create.cshtml", song);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View("/Views/Admin/song/Create.cshtml", song);
            }

        }

        // GET: SongController/Edit/5
        [Route("/admin/songs/{id}/edit")]
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var song = _songService.GetSong(id);
            if (song == null)
            {
                return NotFound();
            }

            List<int> artists = new List<int>();
            List<int> genres = new List<int>();

            foreach (var genre in song.Artists)
            {
                artists.Add(genre.ArtistId);
            }
            foreach (var genre in song.Genres)
            {
                genres.Add(genre.GenreId);
            }

            var _song = new SongEditVM()
            {
                SongId = song.SongId,
                Name = song.Name,
                Slug = song.Slug,
                Lyrics = song.Lyrics,
                Album = song.Album,
                UserName = song.UserName,
                Artists = artists,
                Genres = genres,
            };
            PopulateArtistsDropDownList(song.Artists);
            PopulateGenresDropDownList(song.Genres);
            return View("/Views/Admin/Song/Edit.cshtml", _song);
        }

        // POST: SongController/Edit/5
        [HttpPost("/admin/songs/{id}/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, [FromForm] SongEditVM song)
        {
            try
            {
                if (id != song.SongId)
                {
                    return NotFound();
                }
                var result = await _songService.UpdateSong(song);

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
            PopulateArtistsDropDownList(song.Artists);
            PopulateGenresDropDownList(song.Genres);
            return View("/Views/Admin/Song/Edit.cshtml", song);
        }

        // GET: SongController/Delete/5
        //[Route("/admin/songs/{id}/delete")]
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: SongController/Delete/5
        [HttpPost("/admin/songs/{id}/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }

                var result = await _songService.DeleteSong(id);

                if (result.isSuccess > 0)
                {
                    Message = "Succesfully deleted song with name " + result.name + ".";
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

        private void PopulateArtistsDropDownList(object selectedArtist = null)
        {
            ViewBag.Artists = new SelectList(_artistService.GetAllArtists(), "ArtistId", "Name", selectedArtist);
        }

        private void PopulateGenresDropDownList(object selectedGenre = null)
        {
            ViewBag.Genres = new SelectList(_genreService.GetGenres(), "GenreId", "Name", selectedGenre);
        }
    }
}
