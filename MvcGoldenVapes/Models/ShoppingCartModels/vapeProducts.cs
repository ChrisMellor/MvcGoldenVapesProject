using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace MvcGoldenVapes.Models
{
    [Table("VapeJuices")]

    public class VapeProducts
    {
        [Key]
        public int VapeID { get; set; }
        public string VapeBrand { get; set; }
        public string VapeName { get; set; }
        public int VapeStock { get; set; }
        public double VapePrice { get; set; }
        public string VapeSize { get; set; }
    }
}
