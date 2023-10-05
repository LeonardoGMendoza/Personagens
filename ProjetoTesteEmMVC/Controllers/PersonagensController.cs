using Microsoft.AspNetCore.Mvc;
using ProjetoTesteEmMVC.Data;
using ProjetoTesteEmMVC.Models;

namespace ProjetoTesteEmMVC.Controllers
{
    public class PersonagensController : Controller
    {
        private readonly BancoContext db;

        public PersonagensController(BancoContext conect)
        {
            db = conect;
        }
        public IActionResult Index()
        {
            return View(db.PersonagensDb.ToList());
        }

        [HttpGet]
        public IActionResult CriarPersonagem()
        {

            return View();

        }

        [HttpPost]
        public IActionResult CriarPersonagem(PersonagensModel persona)
        {
           
            db.PersonagensDb.Add(persona);
            db.SaveChanges();
            return RedirectToAction("Index");
          
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Excluir(int id)
        {
           
                var user = db.PersonagensDb.Find(id);
                db.PersonagensDb.Remove(user);
                db.SaveChanges();
                return RedirectToAction("Index");
           
        }
    }
}
