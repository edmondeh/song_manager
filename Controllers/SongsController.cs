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
        private SongService _songService;

        public SongsController(SongService songService)
        {
            _songService = songService;
        }

        // GET: Songs
        public ActionResult Index()
        {
            List<SongVM> songs = _songService.GetSongs();
            return View(songs);
        }

        [Route("~/top_songs")]
        public ActionResult Top_Songs()
        {
            List<TopSongs> songs = _songService.GetTopSongs();
            return View(songs);
        }

        // GET: Songs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Songs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Songs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Songs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Songs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Songs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Songs/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}