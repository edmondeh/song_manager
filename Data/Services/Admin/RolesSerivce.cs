using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Songs_Manager.Data.ViewModels.Admin;
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

        public async Task<List<IdentityRole>> GetAllRoles()
        {
            try
            {
                var allRoles = await _roleManager.Roles.ToListAsync();

                if (allRoles != null)
                {
                    return allRoles;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new List<IdentityRole>();
        }
    }
}
