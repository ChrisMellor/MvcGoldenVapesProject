using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGoldenVapes.Data;
using MvcGoldenVapes.Models.ShoppingCartModels;
using System;
using System.Linq;


namespace MvcGoldenVapes.Models
{
    public class SeedData
    { 


        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new ProductsContext(
                            serviceProvider.GetRequiredService<DbContextOptions<ProductsContext>>()))
            {
               if (context.products.Any())
                {
                    return;
                }
                context.products.AddRange(
 new VapeProducts
 {
     VapeBrand = "Jim",
     VapeName = "Ninja",
     VapePrice = 9.99,
     VapeSize = "10",
     VapeStock = 9
 },
 new VapeProducts
 {
     VapeBrand = "Jerry",
     VapeName = "Daog",
     VapePrice = 9.99,
     VapeSize = "10",
     VapeStock = 9
 },
 new VapeProducts
 {
     VapeBrand = "Bob",
     VapeName = "Cat",
     VapePrice = 9.99,
     VapeSize = "10",
     VapeStock = 9
 }
 );
                 context.SaveChanges();

            }


        }

    }
}
