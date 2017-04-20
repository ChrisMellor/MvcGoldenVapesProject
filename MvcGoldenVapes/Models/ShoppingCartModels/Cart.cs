using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcGoldenVapes.Models.ShoppingCartModels
{
    public class Cart
    {
        public int VapeID { get; set; }
        public string vapeName { get; set; }
        public int quantity { get; set; }
        public double SaleWorth { get; set; }
        public double total { get; set; }
    }

    public class cartDBContext : DbContext
    {
        public DbSet<Cart> carts { get; set; }
    }
}
