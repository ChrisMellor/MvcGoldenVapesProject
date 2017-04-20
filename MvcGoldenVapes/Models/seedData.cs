using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGoldenVapes.Data;
using MvcGoldenVapes.Models.ShoppingCartModels;
using System;
using System.Linq;


namespace MvcGoldenVapes.Models
{
    public class seedData
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
                    new vapeProducts
                    {
                        VapeID = 45,
                        VapeBrand = "Area 51",
                        VapeName = "Xenos",
                        VapePrice = 8.00,
                        VapeSize = "10ml",
                        VapeStock = 1
                    }
                    );
                context.SaveChanges();

            }


        }

    }
}
