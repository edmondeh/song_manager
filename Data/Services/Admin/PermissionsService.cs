using Microsoft.AspNetCore.Identity;
using Songs_Manager.Constants;
using Songs_Manager.Data.ViewModels.Admin;
using Songs_Manager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Services.Admin
{
    public class PermissionsService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public PermissionsService(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<List<string>> GetAllPermissions()
        {
            var role = await _roleManager.FindByNameAsync("SuperAdmin");
            var allPermissions = new List<RoleClaimsVM>();
            var allPermissionss = new List<string>();
            allPermissions.GetPermissions(typeof(Permissions.Users), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Roles), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Permissionss), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Artists), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Songs), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Genres), role.Id);
            allPermissions.GetPermissions(typeof(Permissions.Submissions), role.Id);
            //model.RoleId = roleId;
            var claims = await _roleManager.GetClaimsAsync(role);
            var allClaimValues = allPermissions.Select(a => a.Value).ToList();
            var roleClaimValues = claims.Select(a => a.Value).ToList();
            var authorizedClaims = allClaimValues.Intersect(roleClaimValues).ToList();
            foreach (var permission in allPermissions)
            {
                if (authorizedClaims.Any(a => a == permission.Value))
                {
                    allPermissionss.Add(permission.Value);
                }
            }
            return allPermissionss;
        }
    }
}
