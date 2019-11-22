using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Moji.Data;
using Moji.Entities;

namespace Moji
{
    public class PersonnagesController : Controller
    {
        private readonly MojiDbContext _context;

        public PersonnagesController(MojiDbContext context)
        {
            _context = context;
        }

        // GET: Personnages
        public async Task<IActionResult> Index()
        {
            return View(await _context.Personnages.ToListAsync());
        }

        // GET: Personnages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personnage = await _context.Personnages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personnage == null)
            {
                return NotFound();
            }

            return View(personnage);
        }

        // GET: Personnages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personnages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Prenom,AvatarUrl,Or,SanteActuel,SanteMax,ManaActuel,ManaMax,Xp,Niveau,Genre,IdRace,IdClasse,IdUser")] Personnage personnage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personnage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personnage);
        }

        // GET: Personnages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personnage = await _context.Personnages.FindAsync(id);
            if (personnage == null)
            {
                return NotFound();
            }
            return View(personnage);
        }

        // POST: Personnages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Prenom,AvatarUrl,Or,SanteActuel,SanteMax,ManaActuel,ManaMax,Xp,Niveau,Genre,IdRace,IdClasse,IdUser")] Personnage personnage)
        {
            if (id != personnage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personnage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonnageExists(personnage.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(personnage);
        }

        // GET: Personnages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personnage = await _context.Personnages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personnage == null)
            {
                return NotFound();
            }

            return View(personnage);
        }

        // POST: Personnages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personnage = await _context.Personnages.FindAsync(id);
            _context.Personnages.Remove(personnage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonnageExists(int id)
        {
            return _context.Personnages.Any(e => e.Id == id);
        }
    }
}
