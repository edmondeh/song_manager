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
        [Route("admin/users")]
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
        [Route("admin/users/Create")]
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
        [Route("/admin/users/{id}/edit")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var _user = await _usersSerivce.GetUserWithRoles(id);
            //await _rolesSerivce.GetAllRoles();
            if (_user == null)
            {
                return NotFound();
            }
            PopulateRolesDropDownList(_user.Roles);
            return View("/Views/Admin/Users/Edit.cshtml", _user);
        }

        // POST: UsersController/Edit/5
        [HttpPost("/admin/users/{id}/edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [FromForm] UsersEditVM user)
        {
            try
            {
                if (id != user.UserId)
                {
                    return NotFound();
                }
                var result = await _usersSerivce.UpdateUser(user);

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
            return View("/Views/Admin/Users/Edit.cshtml", user);
        }

        //// GET: UsersController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: UsersController/Delete/5
        [HttpPost("/admin/users/{id}/delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var result = await _usersSerivce.DeleteUser(id);

                if (result.isSuccess > 0)
                {
                    Message = "Succesfully deleted user with name " + result.name + ".";
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

        private void PopulateRolesDropDownList(object selectedRoles = null)
        {
            var roles = _rolesSerivce.GetAllRoles().Result;
            ViewBag.Roles = new SelectList(roles, "Name", "Name", selectedRoles);
        }
    }
}
