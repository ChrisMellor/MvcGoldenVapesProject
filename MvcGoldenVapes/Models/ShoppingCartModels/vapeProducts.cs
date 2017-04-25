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
        [DisplayName("Vape ID")]
        public int VapeID { get; set; }
        [DisplayName("Vape Brand")]
        public string VapeBrand { get; set; }
        [DisplayName("Vape Name")]
        public string VapeName { get; set; }
        [DisplayName("Vape Stock")]
        public int VapeStock { get; set; }
        [DisplayName("Vape Price")]
        [DataType(DataType.Currency)]
        public double VapePrice { get; set; }
        [DisplayName("Vape Size")]
        public string VapeSize { get; set; }
    }
}
