using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcGoldenVapes.Models.ShoppingCartModels;

namespace MvcGoldenVapes.Data
{
    public class productsContext : DbContext
    {
        public productsContext(DbContextOptions<productsContext> options) : base(options)
        {
        }

        DbSet<vapeProducts> products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
             {
                 modelBuilder.Entity<productsContext>().ToTable("VapeJuices");
             }
    }
   
}
