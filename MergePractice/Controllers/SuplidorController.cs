using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MergePractice.Controllers
{
    public class SuplidorController : Controller
    {
        private readonly ISuplidorRepository _suplidorRepository;

        public SuplidorController(ISuplidorRepository suplidorRepository)
        {
            _suplidorRepository = suplidorRepository;
        }

        // GET: SuplidorController
        public ActionResult Index()
        {
            var usuarios = _suplidorRepository.List();
            return View(usuarios);
        }

        // GET: SuplidorController/Details/5
        public ActionResult Details(int id)
        {
            var usuario = _suplidorRepository.ObtenerId(id);
            return View(usuario);
        }

        // GET: SuplidorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuplidorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Suplidor suplidor)
        {
            _suplidorRepository.Agregar(suplidor);
            return RedirectToAction(nameof(Index));
        }
        
        // GET: SuplidorController/Edit/5
        public ActionResult Edit(int id)
        {
            var suplidor = _suplidorRepository.ObtenerId(id);
            return View(suplidor);
        }

        // POST: SuplidorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Suplidor suplidor)
        {
            _suplidorRepository.Modificar(suplidor);
            return RedirectToAction(nameof(Index));
        }

        // GET: SuplidorController/Delete/5
        public ActionResult Delete(int id)
        {
            _suplidorRepository.Remover(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: SuplidorController/Delete/5
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
