using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs_Manager.Data.ViewModels.Admin
{
    public class UsersVM
    {
        public IEnumerable<string> RoleNames { get; set; }
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }

    public class UsersCreateVM
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public List<string> Roles { get; set; }
    }
}
