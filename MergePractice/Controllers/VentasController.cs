using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MergePractice.Controllers
{
    public class VentasController : Controller
    {
        private readonly IVentasRepository ventasRepository;

        public VentasController(IVentasRepository ventasRepository)
        {
            this.ventasRepository = ventasRepository;
        }
        // GET: VentasController
        public ActionResult Index()
        {
            var ventas = this.ventasRepository.List();
            return View(ventas);
        }

        // GET: VentasController/Details/5
        public ActionResult Details(int id)
        {
            var ventas = this.ventasRepository.ObtenerPorId(id);
            return View(ventas);
        }

        // GET: VentasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VentasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ventas ventas)
        {
            this.ventasRepository.Agregar(ventas);
            return RedirectToAction(nameof(Index));
        }

        // GET: VentasController/Edit/5
        public ActionResult Edit(int id)
        {
            var ventas = this.ventasRepository.ObtenerPorId(id);
            return View(ventas);
        }

        // POST: VentasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Ventas ventas)
        {
            this.ventasRepository.Modificar(ventas);
            return RedirectToAction(nameof(Index));
        }

        // GET: VentasController/Delete/5
        public ActionResult Delete(int id)
        {
            this.ventasRepository.Remover(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: VentasController/Delete/5
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
