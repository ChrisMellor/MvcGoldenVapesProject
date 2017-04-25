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
        [DisplayName("Vape ID")]
        public int VapeID { get; set; }
        [DisplayName  ("Vape Name")]
        public string VapeName { get; set; }
        [DisplayName("Vape Price")]
        [DataType(DataType.Currency)]
        public double VapePrice { get; set; }
        public int Quantity { get; set; }
        [DisplayName("Sub Total")]
        [DataType(DataType.Currency)]
        public double SubTotal { get; set; }
    }

}
