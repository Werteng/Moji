using Microsoft.AspNetCore.Mvc;
using Moji.Data;
using Moji.Entities;
using System.Net;
using System.Web.Mvc;

namespace Moji.Controllers
{
    public class PersonnageController : Microsoft.AspNetCore.Mvc.Controller
    {

        private MojiDbContext db = new MojiDbContext();

        //GET : Personnage
        public IActionResult Index()
        {
            var personnages = db.Personnages;
            return View(personnages);
        }

        public IActionResult Create()
        { 
            return View();

        }

        public IActionResult Save(Personnage personnage)
        {
            db.Add(personnage);
            db.SaveChanges();
            return RedirectToAction("Index", "Personnage");
        }

        public IActionResult Edit(Personnage personnage)
        {
            db.Update(personnage);
            db.SaveChanges();
            return View();
        }

        public IActionResult Delete(Personnage personnage)
        {
            db.Remove(personnage);
            return View();
        }

        public IActionResult Details(Personnage personnage)
        {
            return View();
        }

    }
}