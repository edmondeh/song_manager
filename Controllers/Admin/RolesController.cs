using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Songs_Manager.Data.Services.Admin;
using Songs_Manager.Data.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Controllers.Admin
{
    public class RolesController : Controller
    {
        private readonly RolesSerivce _rolesService;

        public RolesController(RolesSerivce rolesService)
        {
            _rolesService = rolesService;
        }

        [TempData]
        public string ErrorMessage { get; set; }
        [TempData]
        public string SuccessMessage { get; set; }

        // GET: RolesController
        [Route("admin/roles")]
        public async Task<IActionResult> Index()
        {
            var roles = await _rolesService.GetAllRolesWithClaimPermissions();
            return View("/Views/Admin/Roles/Index.cshtml", roles);
        }

        //// GET: RolesController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: RolesController/Create
        [Route("admin/roles/create")]
        public ActionResult Create()
        {
            PopulateRolesPermissionsDropDownList();
            return View("/Views/Admin/Roles/Create.cshtml", new RoleCreateVM());
        }

        // POST: RolesController/Create
        [HttpPost("/admin/roles/create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] RoleCreateVM role)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _rolesService.CreateRole(role);

                    if (result)
                    {
                        SuccessMessage = "Succesfully.";
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ErrorMessage = "Something went wrong.";
                    }
                }
                PopulateRolesPermissionsDropDownList(role.Permissions);
                return View("/Views/Admin/Roles/Create.cshtml", role);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View("/Views/Admin/Roles/Create.cshtml", role);
            }
        }

        // GET: RolesController/Edit/5
        [Route("/admin/roles/{id}/edit")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var _role = await _rolesService.GetRoleWithPermissions(id);
            if (_role == null)
            {
                return NotFound();
            }
            return View("/Views/Admin/Roles/Edit.cshtml", _role);
        }

        // POST: RolesController/Edit/5
        [HttpPost("/admin/roles/{id}/edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [FromForm] RoleEditVM role)
        {
            try
            {
                if (id != role.RoleId)
                {
                    return NotFound();
                }
                var result = await _rolesService.UpdateRole(role);

                if (result)
                {
                    SuccessMessage = "Succesfully.";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ErrorMessage = "Something went wrong.";
            return View("/Views/Admin/Roles/Edit.cshtml", role);
        }

        //// GET: RolesController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: RolesController/Delete/5
        [HttpPost("/admin/roles/{id}/delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var result = await _rolesService.DeleteRole(id);

                if (result.isSuccess)
                {
                    SuccessMessage = "Succesfully deleted role with name " + result.name + ".";
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                ErrorMessage = "Something went wrong.";
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        private void PopulateRolesPermissionsDropDownList(object selectedRolePermissions = null)
        {
            //var roles = _rolesService.GetAllRoleClaims().Result;
            //ViewBag.RoleClaims = new SelectList(roles, "Value", "Value", selectedRolePermissions);
            ViewBag.RoleClaims = _rolesService.GetAllRoleClaims().Result;
        }
    }
}
