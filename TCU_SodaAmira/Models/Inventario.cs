using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCU_SodaAmira.Models
{
    public class Inventario
    {
        [Key]
        public int Codigo { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public int PrecioCosto { get; set; }
    }
}
