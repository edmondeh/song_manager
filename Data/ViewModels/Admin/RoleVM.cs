using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.ViewModels.Admin
{
    public class RoleVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UserRolesVM
    {
        public string RoleName { get; set; }
        public bool Selected { get; set; }
    }

    public class RoleCreateVM
    {
        public string RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        public IList<string> Permissions { get; set; }
    }

    public class RoleEditVM
    {
        [Required]
        public string RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        public IList<RoleClaimsVM> RoleClaims { get; set; }
        public IList<string> Permissions { get; set; }
    }
}
