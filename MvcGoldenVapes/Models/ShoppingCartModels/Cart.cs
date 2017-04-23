using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcGoldenVapes.Models
{
        [Table("CustomerOrders")]
    public class Cart
    { 
        [Key]
        public int VapeID { get; set; }
        public string VapeName { get; set; }
        public double VapePrice { get; set; }
        public string Quantity { get; set; }
        public string SubTotal { get; set; }
    }

}
