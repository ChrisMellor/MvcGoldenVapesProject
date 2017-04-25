using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcGoldenVapes.Data;
using Microsoft.EntityFrameworkCore;
using MvcGoldenVapes.Models;

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

        // POST: vapeProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("VapeID,VapeName,VapePrice,Quantity,SubTotal")] Cart Cart)
        {
            if (ModelState.IsValid)
            {
                _OrderContext.Add(Cart);
                await _OrderContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(Cart);
        }

          }
}
