using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Songs_Manager.Constants;
using Songs_Manager.Data.ViewModels.Admin;
using Songs_Manager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Services.Admin
{
    public class RolesSerivce
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RolesSerivce(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<RoleEditVM> GetRoleWithPermissions(string id)
        {
            var model = new RoleEditVM();
            var role = await _roleManager.FindByIdAsync(id);
            var allPermissions = new List<RoleClaimsVM>();
            allPermissions.GetPermissions(typeof(Permissions.Users), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Roles), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Permissionss), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Artists), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Songs), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Genres), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Submissions), role.Id);
            model.RoleId = role.Id;
            model.RoleName = role.Name;
            var claims = await _roleManager.GetClaimsAsync(role);
            var allClaimValues = allPermissions.Select(a => a.Value).ToList();
            var roleClaimValues = claims.Select(a => a.Value).ToList();
            var authorizedClaims = allClaimValues.Intersect(roleClaimValues).ToList();
            foreach (var permission in allPermissions)
            {
                if (authorizedClaims.Any(a => a == permission.Value))
                {
                    permission.Selected = true;
                }
            }
            model.RoleClaims = allPermissions;

            return model;
        }

        public async Task<List<IdentityRole>> GetAllRoles() => await _roleManager.Roles.ToListAsync();
        
        public async Task<List<RoleClaimsVM>> GetAllRoleClaims()
        {
            var allPermissions = new List<RoleClaimsVM>();
            var role = await _roleManager.FindByNameAsync("SuperAdmin");
            allPermissions.GetPermissions(typeof(Permissions.Users), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Roles), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Permissionss), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Artists), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Songs), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Genres), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Submissions), role.Id);
            //var claims = await _roleManager.GetClaimsAsync(role);
            var allClaimValues = allPermissions.Select(a => a.Value).ToList();
            //var roleClaimValues = claims.Select(a => a.Value).ToList();
            //var authorizedClaims = allClaimValues.Intersect(roleClaimValues).ToList();

            return allPermissions;
        }

        public async Task<List<PermissionVM>> GetAllRolesWithClaimPermissions()
        {
            //var roleId = "053969b6-3896-493b-b2b3-68198563aa7b";
            var roles = await _roleManager.Roles.ToListAsync();
            var allRolesWithPermissions = new List<PermissionVM>();
            foreach (var role in roles)
            {
                var model = new PermissionVM();
                var allPermissions = new List<RoleClaimsVM>();
                allPermissions.GetPermissions(typeof(Permissions.Users), role.Id);
                allPermissions.GetPermissions(typeof(Permissions.Roles), role.Id);
                allPermissions.GetPermissions(typeof(Permissions.Permissionss), role.Id);
                allPermissions.GetPermissions(typeof(Permissions.Artists), role.Id);
                allPermissions.GetPermissions(typeof(Permissions.Songs), role.Id);
                allPermissions.GetPermissions(typeof(Permissions.Genres), role.Id);
                allPermissions.GetPermissions(typeof(Permissions.Submissions), role.Id);
                //var role = await _roleManager.FindByIdAsync(roleId);
                model.RoleId = role.Id;
                model.RoleName = role.Name;
                var claims = await _roleManager.GetClaimsAsync(role);
                var allClaimValues = allPermissions.Select(a => a.Value).ToList();
                var roleClaimValues = claims.Select(a => a.Value).ToList();
                var authorizedClaims = allClaimValues.Intersect(roleClaimValues).ToList();
                foreach (var permission in allPermissions)
                {
                    if (authorizedClaims.Any(a => a == permission.Value))
                    {
                        permission.Selected = true;
                    }
                }
                model.RoleClaims = allPermissions;
                allRolesWithPermissions.Add(model);
            }

            return allRolesWithPermissions;
        }

        public async Task<bool> CreateRole(RoleCreateVM role)
        {
            try
            {
                var _role = new IdentityRole()
                {
                    Name = SongService.UpperCase(role.RoleName)
                };

                var result = await _roleManager.CreateAsync(_role);
                foreach(var permission in role.Permissions)
                {
                    await _roleManager.AddPermissionClaim(_role, permission);
                }

                return result.Succeeded;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }

        public async Task<bool> UpdateRole(RoleEditVM role)
        {
            try
            {
                var _role = await _roleManager.FindByIdAsync(role.RoleId);

                var claims = await _roleManager.GetClaimsAsync(_role);
                foreach (var claim in claims)
                {
                    await _roleManager.RemoveClaimAsync(_role, claim);
                }
                //var selectedClaims = role.RoleClaims.Where(a => a.Selected).ToList();
                //foreach (var claim in selectedClaims)
                //{
                //    await _roleManager.AddPermissionClaim(_role, claim.Value);
                //}
                foreach (var permission in role.Permissions)
                {
                    await _roleManager.AddPermissionClaim(_role, permission);
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return false;
        }

        public async Task<(bool isSuccess, string name)> DeleteRole(string id)
        {
            string name = "!";
            try
            {
                var _role = await _roleManager.FindByIdAsync(id);
                name = _role.Name;
                if (_role != null)
                {
                    await _roleManager.DeleteAsync(_role);
                }
                return (true, name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return (false, name);
        }
    }
}
