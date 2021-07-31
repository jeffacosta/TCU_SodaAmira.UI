using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCU_SodaAmira.Models
{
    public class Cierre
    {
        [Key]
        public int NumeroCierre { set; get; }

        public int NumeroFactura { get; set; }

        public int TotalCierre { get; set; }

        public DateTime FechaCierre { get; set; } 
    }
}
