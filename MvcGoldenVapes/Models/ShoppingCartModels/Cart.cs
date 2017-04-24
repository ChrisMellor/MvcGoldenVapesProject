using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcGoldenVapes.Models
{
        [Table("CustomerOrders")]
    public class Cart
    { 
        [Key]
        
        public int VapeID { get; set; }
        [DisplayName  ("Vape Name")]
        public string VapeName { get; set; }
        public double VapePrice { get; set; }
        public string Quantity { get; set; }
        public string SubTotal { get; set; }
    }

}
