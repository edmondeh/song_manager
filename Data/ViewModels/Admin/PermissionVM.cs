using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Data.ViewModels.Admin
{
    public class PermissionVM
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public IList<RoleClaimsVM> RoleClaims { get; set; }
    }
    public class RoleClaimsVM
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
    }
}
