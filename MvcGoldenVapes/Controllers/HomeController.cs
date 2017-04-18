using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcGoldenVapes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "The Vape Store";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Description about the website and the team";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact details";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
