using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace MvcGoldenVapes.Models.ShoppingCartModels
{
    public class vapeStoreEntities : DbContext
    {
        public DbSet<Cart>Carts{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetail>OrderDetails{ get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
