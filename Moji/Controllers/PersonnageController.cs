using Microsoft.AspNetCore.Mvc;
using Moji.Data;
using Moji.Entities;
using System.Linq;
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

        public IActionResult Create(int Id)
        { 
            return View();
        }

        public IActionResult Save(Personnage personnage)
        {
            if (personnage.Id.Equals(null))
            {
                db.Add(personnage);
            } else
            {
                db.Update(personnage);
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Personnage");
        }


        public IActionResult Edit(int Id)
        {
            var personnages = db.Personnages.ToList();
            Personnage result = new Personnage();
            foreach (Personnage perso in personnages)
            {
                if (perso.Id == Id)
                {
                    result = perso;
                }
            }
            return View(result);
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