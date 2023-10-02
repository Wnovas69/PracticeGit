using MergePractice.Data.Entities;
using MergePractice.Data.Interfaces;
using MergePractice.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MergePractice.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }
        // GET: UsuarioController
        public ActionResult Index()
        {
            var usuarios = this.usuarioRepository.List();
            return View(usuarios);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            var usuarios = this.usuarioRepository.ObtenerId(id);
            return View(usuarios);
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario usuario)
        {
            this.usuarioRepository.Agregar(usuario);
            return RedirectToAction(nameof(Index));
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = this.usuarioRepository.ObtenerId(id);
            return View(usuario);
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Usuario usuario)
        {
            this.usuarioRepository.Modificar(usuario);
            return RedirectToAction(nameof(Index));
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
           this.usuarioRepository.Remover(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: UsuarioController/Delete/5
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
