using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcGoldenVapes.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcGoldenVapes.Controllers
{
    public class StoreController : Controller
    {
        private readonly ProductsContext _context;
        private readonly OrderContext _OrderContext;
        public StoreController(ProductsContext context, OrderContext OrderContext)
        {
            _context = context;
            _OrderContext = OrderContext;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }
        // GET: vapeProducts

        // GET: /<controller>/

        public async Task<IActionResult> ShoppingCart()
        {
            ViewData["Message"] = "Page for all items added to cart (refresh upon load?)";

            return View(await _OrderContext.Orders.ToListAsync());
        }
    
        public IActionResult Payment()
        {

            ViewData["Message"] = "The Page To Acquire Payment Details";

            return View();

        }

        private bool OrdersExists(int id)
        {
            return _OrderContext.Orders.Any(e => e.VapeID == id);
        }

    }
}
