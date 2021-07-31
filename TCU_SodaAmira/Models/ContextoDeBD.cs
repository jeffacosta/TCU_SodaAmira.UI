using Microsoft.EntityFrameworkCore;
using TCU_SodaAmira.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCU_SodaAmira.Models
{

    public class ContextoDeBD: DbContext
    {
        public ContextoDeBD()
        {

        }

        public ContextoDeBD(DbContextOptions<ContextoDeBD> opciones) : base(opciones)
        {

        }

        public DbSet<Persona> Persona { get; set; }

        public DbSet<Cierre> Cierre { get; set; }

//        public DbSet<Factura> Factura { get; set; }

        public DbSet<Ingrediente> Ingrediente { get; set; }

        public DbSet<Inventario> Inventario { get; set; }

//        public DbSet<Mesa> Mesa { get; set; }


    }
}
