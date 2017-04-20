using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcGoldenVapes.Models.ShoppingCartModels;

namespace MvcGoldenVapes.Data
{
    public class ProductsContext : DbContext
    {
        public  ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {
        }

        public DbSet<vapeProducts>products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
             {
                 modelBuilder.Entity<vapeProducts>().ToTable("VapeJuices");
             }
    }
   
}
