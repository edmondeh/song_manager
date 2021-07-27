using Microsoft.AspNetCore.Identity;
using Songs_Manager.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Songs_Manager.Seeds
{
    public static class DefaultUsers
    {
        public static async Task SeedUserAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new IdentityUser
            {
                UserName = "user1@gmail.com",
                Email = "user1@gmail.com",
                EmailConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Password1.");
                    await userManager.AddToRoleAsync(defaultUser, Roles.User.ToString());
                }
                await roleManager.SeedClaimsForUser();
            }
        }
        public static async Task SeedAdminAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Password1.");
                    await userManager.AddToRoleAsync(defaultUser, Roles.User.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.Admin.ToString());
                }
                await roleManager.SeedClaimsForAdmin();
            }
        }
        public static async Task SeedSuperAdminAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new IdentityUser
            {
                UserName = "superadmin@gmail.com",
                Email = "superadmin@gmail.com",
                EmailConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Password1.");
                    await userManager.AddToRoleAsync(defaultUser, Roles.User.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.SuperAdmin.ToString());
                }
                await roleManager.SeedClaimsForSuperAdmin();
            }
        }
        private async static Task SeedClaimsForUser(this RoleManager<IdentityRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("User");
            await roleManager.AddPermissionClaim(adminRole, "Submissions");
        }
        private async static Task SeedClaimsForAdmin(this RoleManager<IdentityRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            await roleManager.AddPermissionClaim(adminRole, "Artists");
            await roleManager.AddPermissionClaim(adminRole, "Songs");
            await roleManager.AddPermissionClaim(adminRole, "Genres");
            await roleManager.AddPermissionClaim(adminRole, "Submissions");
        }
        private async static Task SeedClaimsForSuperAdmin(this RoleManager<IdentityRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("SuperAdmin");
            await roleManager.AddPermissionClaim(adminRole, "Users");
            await roleManager.AddPermissionClaim(adminRole, "Roles");
            await roleManager.AddPermissionClaim(adminRole, "Permissionss");
            await roleManager.AddPermissionClaim(adminRole, "Artists");
            await roleManager.AddPermissionClaim(adminRole, "Songs");
            await roleManager.AddPermissionClaim(adminRole, "Genres");
            await roleManager.AddPermissionClaim(adminRole, "Submissions");
        }
        public static async Task AddPermissionClaim(this RoleManager<IdentityRole> roleManager, IdentityRole role, string module)
        {
            var allClaims = await roleManager.GetClaimsAsync(role);
            var allPermissions = Permissions.GeneratePermissionsForModule(module);
            foreach (var permission in allPermissions)
            {
                if (!allClaims.Any(a => a.Type == "Permission" && a.Value == permission))
                {
                    await roleManager.AddClaimAsync(role, new Claim("Permission", permission));
                }
            }
        }
    }
}
