using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCU_SodaAmira.Models
{
    public class RepositorioDelRestaurante: IRepositorioDelRestaurante
    {
        private ContextoDeBD ElcontextoDeBaseDeDatos;


        //Listar 


        public RepositorioDelRestaurante(ContextoDeBD contexto)
        {
            ElcontextoDeBaseDeDatos = contexto;
        }

        public List<Persona> ObtenerTodasLasPersonas()
        {
            List<Persona> Lalista = ElcontextoDeBaseDeDatos.Persona.ToList();

            return Lalista;
        }

        public List<Cierre> ObtenerTodasLosCierres()
        {
            List<Cierre> Lalista = ElcontextoDeBaseDeDatos.Cierre.ToList();

            return Lalista;
        }

        public List<Ingrediente> ObtenerTodosLosIngredientes()
        {
            List<Ingrediente> Lalista = ElcontextoDeBaseDeDatos.Ingrediente.ToList();

            return Lalista;
        }

        public List<Inventario> ObtenerTodoElInventario()
        {
            List<Inventario> Lalista = ElcontextoDeBaseDeDatos.Inventario.ToList();

            return Lalista;
        }

        //Fin Listar


        //Añadir

        public void AgregarInventario(Inventario inventario)
        {
            ElcontextoDeBaseDeDatos.Inventario.Add(inventario);
            ElcontextoDeBaseDeDatos.SaveChanges();
        }
    }
}
