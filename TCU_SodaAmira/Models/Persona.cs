using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCU_SodaAmira.Models
{
    public class Persona
    {
        [Key]
        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string SegundoNombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }
    }
}
