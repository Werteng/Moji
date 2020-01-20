using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moji.Data;
using Moji.Entities;
using Moji.ViewModels;
using System.Linq;
using System.Net;


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
            var classes = db.Classes.Select(c => new SelectListItem { Text = c.Libelle, Value = c.Id.ToString() }).ToList();
            var races = db.Races.Select(c => new SelectListItem { Text = c.Libelle, Value = c.Id.ToString() }).ToList();

            return View(new PersonnageViewModel() { ClassItems=classes,RaceItems=races});
        }

        public IActionResult Save(Personnage personnage)
        {
            if (ModelState.IsValid)
            {
                if (personnage.Id.Equals(null))
                {
                    personnage.assignAvatar();
                    db.Add(personnage);
                }
                else
                {
                    personnage.assignAvatar();
                    db.Update(personnage);
                }
                db.SaveChanges();
            }
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
            return View(personnage);
        }

        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personnages = db.Personnages;
            Personnage result = new Personnage();
            foreach (Personnage perso in personnages)
            {
                if (perso.Id == id)
                {
                    result = perso;
                }
            }

            return View(result);
        }

    }
}