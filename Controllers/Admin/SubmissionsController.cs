using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Songs_Manager.Controllers.Admin
{
    public class SubmissionsController : Controller
    {

        [Route("/admin/submissions")]
        public IActionResult Index()
        {

            return View("/Views/Admin/Submissons/Index.cshtml");
        }
    }
}
