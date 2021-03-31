using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SeminarCore2.Data;
using SeminarCore2.Models;

namespace SeminarCore2.Controllers
{
    public class PredbiljezbeController : Controller
    {
        private readonly MojContext _context;

        public PredbiljezbeController(MojContext context)
        {
            _context = context;
        }

        // GET: Predbiljezbas
        public async Task<IActionResult> Index()
        {
            var predbiljezbe = _context.Predbiljezbe
                .Include(p => p.Seminar)
                .AsNoTracking();

            return View(await predbiljezbe.ToListAsync());
        }

        // GET: Predbiljezbas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predbiljezba = await _context.Predbiljezbe
                .Include(p => p.Seminar)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.PredbiljezbaID == id);

            if (predbiljezba == null)
            {
                return NotFound();
            }

            return View(predbiljezba);
        }

        // GET: Predbiljezbas/Create
        [AllowAnonymous]
        //public IActionResult Create(int? id)
        public async Task<IActionResult> Create(int? id)
        {
            var model = new Predbiljezba()
            {
                Datum = DateTime.Now,
                SeminarID = id ?? -1
            };

            if (model.SeminarID != -1)
            {
                var seminar = await _context.Seminari.FindAsync(model.SeminarID);

                if (seminar == null)
                {
                    return NotFound();
                }
            }

            ViewData["SeminarID"] = new SelectList(_context.Seminari, "SeminarID", "Naziv");
            return View(model);
        }

        // POST: Predbiljezbas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("PredbiljezbaID,Datum,Ime,Prezime,Adresa,Email,BrojTelefona,StatusDaNe,SeminarID")] Predbiljezba predbiljezba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(predbiljezba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SeminarID"] = new SelectList(_context.Seminari, "SeminarID", "Naziv", predbiljezba.SeminarID);
            return View(predbiljezba);
        }

        // GET: Predbiljezbas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predbiljezba = await _context.Predbiljezbe.FindAsync(id);
            if (predbiljezba == null)
            {
                return NotFound();
            }
            ViewData["SeminarID"] = new SelectList(_context.Seminari, "SeminarID", "Naziv", predbiljezba.SeminarID);
            return View(predbiljezba);
        }

        // POST: Predbiljezbas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PredbiljezbaID,Datum,Ime,Prezime,Adresa,Email,BrojTelefona,StatusDaNe,SeminarID")] Predbiljezba predbiljezba)
        {
            if (id != predbiljezba.PredbiljezbaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(predbiljezba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PredbiljezbaExists(predbiljezba.PredbiljezbaID))
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
            ViewData["SeminarID"] = new SelectList(_context.Seminari, "SeminarID", "Naziv", predbiljezba.SeminarID);
            return View(predbiljezba);
        }

        // GET: Predbiljezbas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var predbiljezba = await _context.Predbiljezbe
                .Include(p => p.Seminar)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.PredbiljezbaID == id);

            if (predbiljezba == null)
            {
                return NotFound();
            }

            return View(predbiljezba);
        }

        // POST: Predbiljezbas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var predbiljezba = await _context.Predbiljezbe.FindAsync(id);
            _context.Predbiljezbe.Remove(predbiljezba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PredbiljezbaExists(int id)
        {
            return _context.Predbiljezbe.Any(e => e.PredbiljezbaID == id);
        }
    }
}
