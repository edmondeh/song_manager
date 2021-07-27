using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Songs_Manager.Data.Services.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Controllers.Admin
{
    public class PermissionsController : Controller
    {
        private readonly PermissionsService _permissionsService;

        public PermissionsController(PermissionsService permissionsService)
        {
            _permissionsService = permissionsService;
        }

        [TempData]
        public string ErrorMessage { get; set; }
        [TempData]
        public string SuccessMessage { get; set; }

        // GET: PermissionsController
        [Route("admin/permissions")]
        public async Task<IActionResult> Index()
        {
            var permissions = await _permissionsService.GetAllPermissions();
            return View("/Views/Admin/Permissions/Index.cshtml", permissions);
        }

        // GET: PermissionsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PermissionsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PermissionsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PermissionsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PermissionsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PermissionsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PermissionsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
