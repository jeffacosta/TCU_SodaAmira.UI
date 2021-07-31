using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCU_SodaAmira.Models
{
    public interface IRepositorioDelRestaurante
    {
        public List<Persona> ObtenerTodasLasPersonas();

        public List<Cierre> ObtenerTodasLosCierres();

        public List<Ingrediente> ObtenerTodosLosIngredientes();

        public List<Inventario> ObtenerTodoElInventario();

        public void AgregarInventario(Inventario inventario);
    }
}
