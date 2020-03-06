﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Moji.Data;
using Moji.Entities;
using Moji.ViewModels;
using System.Linq;
using System.Net;


namespace Moji.Controllers
{

    public class PersonnageController : Microsoft.AspNetCore.Mvc.Controller
    {

        private readonly MojiDbContext db = new MojiDbContext();

        //GET : Personnage
        public IActionResult Index()
        {
            var personnages = db.Personnages.Include(x=>x.Race).Include(x=>x.Classe);

            return View(personnages);
        }

        public IActionResult Create()
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
                    db.Add(personnage);
                }
                else
                {
                    db.Update(personnage);
                }
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Personnage");
        }


        public IActionResult Edit(int Id)
        {
            var classes = db.Classes.Select(c => new SelectListItem { Text = c.Libelle, Value = c.Id.ToString() }).ToList();
            var races = db.Races.Select(c => new SelectListItem { Text = c.Libelle, Value = c.Id.ToString() }).ToList();
            var personnages = db.Personnages.ToList();
            PersonnageViewModel result = new PersonnageViewModel();
            foreach (Personnage perso in personnages)
            {
                if (perso.Id == Id)
                {
                    result.Id = perso.Id;
                    result.Nom = perso.Nom;
                    result.Prenom = perso.Prenom;
                    result.ClasseId = perso.ClasseId;
                    result.RaceId = perso.RaceId;
                    result.ClassItems=classes;
                    result.RaceItems = races;

                }
            }
            return View(result);
        }


        public IActionResult DeletePage(int Id)
        {
            var personnages = db.Personnages.Include(x => x.Race).Include(x => x.Classe);
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

        public IActionResult Delete(int Id)
        {
            var personnages = db.Personnages.Include(x => x.Race).Include(x => x.Classe);
            Personnage result = new Personnage();
            foreach (Personnage perso in personnages)
            {
                if (perso.Id == Id)
                {
                    result = perso;
                }
            }
            db.Remove(result);
            db.SaveChanges();
            return RedirectToAction("Index", "Personnage");
        }





        public IActionResult Details(int id)
        {
            var personnages = db.Personnages.Include(x => x.Race).Include(x => x.Classe);
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