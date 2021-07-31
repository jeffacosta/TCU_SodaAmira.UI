using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TCU_SodaAmira.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the UsuariosLogin class
    public class UsuariosLogin : IdentityUser
    {   [PersonalData]
         [Column(TypeName ="nvarchar (50)")]
        public string Usuario { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar (50)")]
        public string Contrasena { get; set; }
    }
}
