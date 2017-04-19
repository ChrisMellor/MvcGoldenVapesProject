using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcGoldenVapes.Models.ShoppingCartModels
{
    public class products
    {
        public int ID { get; set; }
        public string brand { get; set; }
        public string name { get; set; }
        public int stock { get; set; }
        public double price { get; set; }
        public int size { get; set; }
    }

    public class productDBContext : DbContext
    {
        public DbSet<products> Product { get; set; }
    }
}
