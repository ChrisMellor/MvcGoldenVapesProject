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

        [Required]
        [DisplayName  ("Vape Name")]
        [DataType(DataType.Text)]
        [StringLength(35)]
        [RegularExpression(@"^([a - zA - Z] +)$", ErrorMessage = "Invalid Name for Vape Product")]
        public string VapeName { get; set; }

        [Required]
        [DisplayName("Vape Price")]
        [DataType(DataType.Currency)]
        [Range(0, 999.99)]
        [RegularExpression(@"^[1-9]\d*(\.\d+)?$", ErrorMessage = "Invalid Price")]
        public double VapePrice { get; set; }

        [Required]
        [Range(0, 25)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Invalid Qauntity")]
        public int Quantity { get; set; }

        [DisplayName("Sub Total")]
        [DataType(DataType.Currency)]
        [RegularExpression(@"^[1-9]\d*(\.\d+)?$", ErrorMessage = "Invalid Sub Total")]
        [Required]
        [Range(0, 999.99)]
        public double SubTotal { get; set; }
    }

}
