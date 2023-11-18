using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MergePractice.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductoRepository productoRepository;

        public ProductoController(IProductoRepository productoRepository)
        {
            this.productoRepository = productoRepository;
        }
        // GET: ProductoController
        public ActionResult Index()
        {
            var producto = this.productoRepository.List();
            return View(producto);
        }

        // GET: ProductoController/Details/5
        public ActionResult Details(int id)
        {
            var producto = this.productoRepository.ObtenerId(id);
            return View(producto);
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Producto producto)
        {
            this.productoRepository.Agregar(producto);
            return RedirectToAction(nameof(Index));

        }

        // GET: ProductoController/Edit/5
        public ActionResult Edit(int id)
        {
            var producto = this.productoRepository.ObtenerId(id);
            return View(producto);
        }

        // POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Producto producto)
        {
            this.productoRepository.Modificar(producto);
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductoController/Delete/5
        public ActionResult Delete(int id)
        {
            this.productoRepository.Remover(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: ProductoController/Delete/5
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
