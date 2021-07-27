using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Songs_Manager.Data.Models.Identity;
using Songs_Manager.Data.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.Services.Admin
{
    public class UsersSerivce
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UsersSerivce(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityUser> GetUser(string id) => await _userManager.FindByIdAsync(id.ToString());

        public async Task<UsersEditVM> GetUserWithRoles(string userId)
        {
            var userRoles = new List<UserRolesVM>();
            var _user = await _userManager.FindByIdAsync(userId);
            foreach (var role in _roleManager.Roles)
            {
                var userRolesVM = new UserRolesVM
                {
                    RoleName = role.Name
                };
                if (await _userManager.IsInRoleAsync(_user, role.Name))
                {
                    userRolesVM.Selected = true;
                }
                else
                {
                    userRolesVM.Selected = false;
                }
                userRoles.Add(userRolesVM);
            }
            var model = new UsersEditVM()
            {
                UserId = userId,
                UserName = _user.UserName,
                Email = _user.Email,
                Roles = userRoles
            };
            return model;
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
                    UserName = user.Email,
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

        public async Task<int> UpdateUser(UsersEditVM user)
        {
            try
            {
                var _user = await _userManager.FindByIdAsync(user.UserId);
                if(_user == null)
                {
                    return 0;
                }
                _user.UserName = user.Email;
                _user.Email = user.Email;
                var roles = await _userManager.GetRolesAsync(_user);
                var newRoles = user.NewRoles;
                await _userManager.RemoveFromRolesAsync(_user, roles);
                await _userManager.AddToRolesAsync(_user, newRoles);
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return 0;
        }

        public async Task<(int isSuccess, string name)> DeleteUser(string id)
        {
            string name = "!";
            try
            {
                var _user = await _userManager.FindByIdAsync(id);
                name = _user.UserName;
                if (_user != null)
                {
                    await _userManager.DeleteAsync(_user);
                }
                return (1, name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return (0, name);
        }
    }
}
