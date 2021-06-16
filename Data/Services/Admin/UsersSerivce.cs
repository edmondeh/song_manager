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
    public class UsersSerivce
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        public UsersSerivce(IHttpContextAccessor httpContextAccessor, UserManager<IdentityUser> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<List<UsersVM>> GetAllUsersWithRolesExceptCurrentUser()
        {
            try
            {
                var allUsersWithRoles = new List<UsersVM>();
                var currentUser = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
                var allUsersExceptCurrentUser = await _userManager.Users.Where(a => a.Id != currentUser.Id).ToListAsync();

                //if (allUsersExceptCurrentUser != null)
                //{
                //    return allUsersExceptCurrentUser;
                //}

                foreach (var user in allUsersExceptCurrentUser)
                {
                    var r = new UsersVM
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Email = user.Email
                    };
                    allUsersWithRoles.Add(r);
                }

                foreach (var user in allUsersWithRoles)
                {
                    user.RoleNames = await _userManager.GetRolesAsync(await _userManager.Users.FirstAsync(s => s.UserName == user.UserName));
                }

                return allUsersWithRoles;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return new List<UsersVM>();
        }

        public async Task<int> CreateUser(UsersCreateVM user)
        {
            try
            {
                var _user = new IdentityUser()
                {
                    UserName = SongService.UpperCase(user.UserName),
                    Email = user.Email,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                };

                await _userManager.CreateAsync(_user);
                var userNew = await _userManager.FindByEmailAsync(_user.Email);

                foreach(var role in user.Roles)
                {
                    await _userManager.AddToRoleAsync(userNew, role);
                }

                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }
    }
}
