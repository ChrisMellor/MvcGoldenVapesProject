using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcGoldenVapes.Data;
using MvcGoldenVapes.Models.ShoppingCartModels;


namespace MvcGoldenVapes.Controllers
{
    public class vapeProductsController : Controller
    {
        private readonly ProductsContext _context;

        public vapeProductsController(ProductsContext context)
        {
            _context = context;    
        }

        // GET: vapeProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.products.ToListAsync());
        }

  

        // GET: vapeProducts/Details/5
public async Task<IActionResult> Details(int? id)
{
if (id == null)
{
return NotFound();
}

            var vapeProducts = await _context.products
                            .SingleOrDefaultAsync(m => m.VapeID == id);
            if (vapeProducts == null)
            {
return NotFound();
}
return View(vapeProducts);
}

        // GET: vapeProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: vapeProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VapeID,VapeBrand,VapeName,VapeStock,VapePrice,VapeSize")] vapeProducts vapeProducts)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vapeProducts);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(vapeProducts);
        }

        // GET: vapeProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vapeProducts = await _context.products.SingleOrDefaultAsync(m => m.VapeID == id);
            if (vapeProducts == null)
            {
                return NotFound();
            }
            return View(vapeProducts);
        }

        // POST: vapeProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VapeID,VapeBrand,VapeName,VapeStock,VapePrice,VapeSize")] vapeProducts vapeProducts)
        {
            if (id != vapeProducts.VapeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vapeProducts);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!vapeProductsExists(vapeProducts.VapeID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(vapeProducts);
        }
        // GET: vapeProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vapeProducts = await _context.products
                .SingleOrDefaultAsync(m => m.VapeID == id);
            if (vapeProducts == null)
            {
                return NotFound();
            }

            return View(vapeProducts);
        }

        // POST: vapeProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vapeProducts = await _context.products.SingleOrDefaultAsync(m => m.VapeID == id);
            _context.products.Remove(vapeProducts);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool vapeProductsExists(int id)
        {
            return _context.products.Any(e => e.VapeID == id);
        }
    }
}
