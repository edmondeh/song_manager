using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs_Manager.Constants
{
    public static class Permissions
    {
        public static List<string> GeneratePermissionsForModule(string module)
        {
            return new List<string>()
            {
                $"Permissions.{module}.Create",
                $"Permissions.{module}.View",
                $"Permissions.{module}.Edit",
                $"Permissions.{module}.Delete",
            };
        }
        public static class Users
        {
            public const string View = "Permissions.Users.View";
            public const string Create = "Permissions.Users.Create";
            public const string Edit = "Permissions.Users.Edit";
            public const string Delete = "Permissions.Users.Delete";
        }
        public static class Roles
        {
            public const string View = "Permissions.Roles.View";
            public const string Create = "Permissions.Roles.Create";
            public const string Edit = "Permissions.Roles.Edit";
            public const string Delete = "Permissions.Roles.Delete";
        }
        public static class Permissionss
        {
            public const string View = "Permissions.Permissionss.View";
            public const string Create = "Permissions.Permissionss.Create";
            public const string Edit = "Permissions.Permissionss.Edit";
            public const string Delete = "Permissions.Permissionss.Delete";
        }
        public static class Artists
        {
            public const string View = "Permissions.Artists.View";
            public const string Create = "Permissions.Artists.Create";
            public const string Edit = "Permissions.Artists.Edit";
            public const string Delete = "Permissions.Artists.Delete";
        }
        public static class Songs
        {
            public const string View = "Permissions.Songs.View";
            public const string Create = "Permissions.Songs.Create";
            public const string Edit = "Permissions.Songs.Edit";
            public const string Delete = "Permissions.Songs.Delete";
        }
        public static class Genres
        {
            public const string View = "Permissions.Genres.View";
            public const string Create = "Permissions.Genres.Create";
            public const string Edit = "Permissions.Genres.Edit";
            public const string Delete = "Permissions.Genres.Delete";
        }
        public static class Submissions
        {
            public const string View = "Permissions.Submissions.View";
            public const string Create = "Permissions.Submissions.Create";
            public const string Edit = "Permissions.Submissions.Edit";
            public const string Delete = "Permissions.Submissions.Delete";
        }
    }
}
