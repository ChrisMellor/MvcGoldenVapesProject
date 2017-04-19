using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcGoldenVapes.Models.ShoppingCartModels
{
    public class sales
    {
        public int vapeID { get; set; }
        public string vapeName { get; set; }
        public int quantity { get; set; }
        public double sale { get; set; }
        public double totalSale { get; set; }
    }
}
