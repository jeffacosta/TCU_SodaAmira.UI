using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCU_SodaAmira.Models
{
    public class Ingrediente
    {
        public int NumeroIngrediente { get; set; }

        [Key]
        public int Codigo { get; set; } 
    }
}
