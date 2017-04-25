using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGoldenVapes.Data;
using MvcGoldenVapes.Models;
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
                if (context.Products.Any())
                {
                    return;
                }
                context.Products.AddRange(
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

                using (var CConext = new OrderContext(
                                             serviceProvider.GetRequiredService<DbContextOptions<OrderContext>>()))
                {
                    if (CConext.Orders.Any())
                    {
                        return;
                    }
                    CConext.Orders.AddRange(
                        new Cart
                        {
                            VapeID = 1,
                            VapeName = "Tom",
                            VapePrice = 9.99,
                            Quantity = 4,
                            SubTotal = 22
                        },
                        new Cart
                        {
                            VapeID = 1,
                            VapeName = "Tom",
                            VapePrice = 9.99,
                            Quantity = 4,
                            SubTotal = 22
                        },
                        new Cart
                        {
                            VapeID = 1,
                            VapeName = "Tom",
                            VapePrice = 9.99,
                            Quantity =  4,
                            SubTotal = 22
                        }
                    );
                    context.SaveChanges();
                    CConext.SaveChanges();
                }
            }
        }
    }
}