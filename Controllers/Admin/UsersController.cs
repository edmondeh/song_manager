using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Songs_Manager.Data.Services.Admin;
using Songs_Manager.Data.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Controllers.Admin
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly UsersSerivce _usersSerivce;
        private readonly RolesSerivce _rolesSerivce;
        public UsersController(UsersSerivce usersSerivce, RolesSerivce rolesService)
        {
            _usersSerivce = usersSerivce;
            _rolesSerivce = rolesService;
        }

        [TempData]
        public string Error { get; set; }
        [TempData]
        public string Message { get; set; }

        // GET: UsersController
        [Route("Admin/Users")]
        public async Task<IActionResult> Index()
        {
            var users = await _usersSerivce.GetAllUsersWithRolesExceptCurrentUser();
            return View("/Views/Admin/Users/Index.cshtml", users);
        }

        // GET: UsersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsersController/Create
        [Route("Admin/Users/Create")]
        public ActionResult Create()
        {
            PopulateRolesDropDownList();
            return View("/Views/Admin/Users/Create.cshtml", new UsersCreateVM());
        }

        // POST: UsersController/Create
        [HttpPost("/admin/users/create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] UsersCreateVM user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _usersSerivce.CreateUser(user);

                    if (result > 0)
                    {
                        Message = "Succesfully.";
                        return RedirectToAction(nameof(Index));
                    }
                }
                Error = "Error";
                Message = "Something went wrong.";
                PopulateRolesDropDownList(user.Roles);
                return View("/Views/Admin/Users/Create.cshtml", user);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View("/Views/Admin/Users/Create.cshtml", user);
            }
        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersController/Edit/5
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

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersController/Delete/5
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

        private void PopulateRolesDropDownList(object selectedRoles = null)
        {
            ViewBag.Roles = new SelectList(_rolesSerivce.GetAllRoles().Result.AsEnumerable<IdentityRole>(), "Name", "Name", selectedRoles);
        }
    }
}
