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
    [Table("VapeJuices")]

    public class VapeProducts
    {
        [Key]

        [Required]
        [DisplayName("Vape ID")]
        public int VapeID { get; set; }

        [Required]
        [DisplayName("Vape Brand")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^([a - zA - Z] +)$", ErrorMessage = "Invalid Name for Vape Brand")]
        public string VapeBrand { get; set; }

        [Required]
        [DisplayName("Vape Name")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^([a - zA - Z] +)$", ErrorMessage = "Invalid Name for Vape Product")]
        public string VapeName { get; set; }

        [Required]
        [DisplayName("Vape Stock")]
        [Range(0, 25)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Invalid Qauntity")]
        public int VapeStock { get; set; }

        [Required]
        [DisplayName("Vape Price")]
        [DataType(DataType.Currency)]
        [Range(0, 999.99)]
        [RegularExpression(@"^[1-9]\d*(\.\d+)?$", ErrorMessage = "Invalid Total")]
        public double VapePrice { get; set; }

        [Required]
        [DisplayName("Vape Size")]
        [DataType(DataType.Text)]
        public string VapeSize { get; set; }
    }
}
