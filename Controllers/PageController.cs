using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Songs_Manager.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}