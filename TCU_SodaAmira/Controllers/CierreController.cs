using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCU_SodaAmira.Models;

namespace TCU_SodaAmira.Controllers
{
    public class CierreController : Controller
    {
        private readonly IRepositorioDelRestaurante Repositorio;

        public CierreController(IRepositorioDelRestaurante repositorio)
        {
            Repositorio = repositorio;
        }

        // GET: CierreController
        public ActionResult Index()
        {
            List<Cierre> gente;

            gente = Repositorio.ObtenerTodasLosCierres();

            return View(gente);
        }

        // GET: CierreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CierreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CierreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: CierreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CierreController/Edit/5
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

        // GET: CierreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CierreController/Delete/5
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
