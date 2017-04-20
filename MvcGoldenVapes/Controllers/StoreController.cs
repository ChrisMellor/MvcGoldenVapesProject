using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcGoldenVapes.Controllers
{
    public class StoreController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Message"] = "VAPE NATION BOYS";

            return View();
        }

        public IActionResult Area51()
        {
            ViewData["Message"] = "Out of this world";

            return View();
        }

        public IActionResult GrimReaper()
        {
            ViewData["Message"] = "It's grim time";

            return View();
        }
        public IActionResult InspiredHaze()
        {
            ViewData["Message"] = "It's a bit of a Inspired Haze";

            return View();
        }
        public IActionResult SimplyVapour()
        {
            ViewData["Message"] = "Simply Vapour, What else?";

            return View();
        }
        public IActionResult VapourCrew()
        {
            ViewData["Message"] = "Vapour Crew is what we do!";

            return View();
        }
        public IActionResult ZombieJuice()
        {
            ViewData["Message"] = "Get it before Umbrella does!";

            return View();
        }

        public IActionResult ShoppingCart()
        {
            ViewData["Message"] = "Page for all items added to cart (refresh upon load?)";

            return View();
        }
        [HttpGet]
        public IActionResult Payment()
        {

            ViewData["Message"] = "The Page To Acquire Payment Details";

            return View();

        }
        [HttpPost]
        public IActionResult Payment(String FirstName, string LastName, string CreditCardNumber, string ExpDate, string SecurityCode, string Address1, string Address2) 
        {

            return View();
            

        }

    }
}
