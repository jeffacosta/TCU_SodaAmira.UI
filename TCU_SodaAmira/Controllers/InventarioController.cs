using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCU_SodaAmira.Models;

namespace TCU_SodaAmira.Controllers
{
    public class InventarioController : Controller
    {
        private readonly IRepositorioDelRestaurante Repositorio;

        public InventarioController(IRepositorioDelRestaurante repositorio)
        {
            Repositorio = repositorio;
        }

        // GET: PersonaController
        public ActionResult Index()
        {
            List<Inventario> gente;

            gente = Repositorio.ObtenerTodoElInventario();

            return View(gente);
        }

        // GET: InventarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InventarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InventarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Inventario inventario)
        {
            try
            {
                Repositorio.AgregarInventario(inventario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InventarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InventarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InventarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InventarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
