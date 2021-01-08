﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SeminarCore2.Data;
using SeminarCore2.Models;

namespace SeminarCore2.Controllers
{
    public class SeminarsController : Controller
    {
        private readonly MojContext _context;

        public SeminarsController(MojContext context)
        {
            _context = context;
        }

        // GET: Seminars
        public async Task<IActionResult> Index(string sortOrder)
        {
            ViewData["NazivSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DatumSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["BrojSortParm"] = sortOrder == "Broj" ? "broj_desc" : "Broj";

            var seminari = from s in _context.Seminari
                            .Include(x => x.Predbiljezbe) //dodao
                           select s;

            switch (sortOrder)
            {
                case "name_desc":
                    seminari = seminari.OrderByDescending(s => s.Naziv);
                    break;
                case "Date":
                    seminari = seminari.OrderBy(s => s.Datum);
                    break;
                case "date_desc":
                    seminari = seminari.OrderByDescending(s => s.Datum);
                    break;
                case "Broj":
                    seminari = seminari.OrderBy(s => s.Predbiljezbe.Count).ThenBy(n => n.PopunjenDaNe); //then by
                    break;
                case "broj_desc":
                    seminari = seminari.OrderByDescending(s => s.Predbiljezbe.Count);
                    break;
                default:
                    seminari = seminari.OrderBy(s => s.Naziv);
                    break;
            }
            return View(await seminari.AsNoTracking().ToListAsync());
        }
        // GET: Seminars/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            #region Info
            /*
            The scaffolded code for the Students Index page left out the Enrollments property, 
            because that property holds a collection. In the Details page, you'll display the contents 
            of the collection in an HTML table.
            */ 
            #endregion

            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminari
                .Include(x=>x.Predbiljezbe)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.SeminarID == id);

            if (seminar == null)
            {
                return NotFound();
            }

            return View(seminar);
        }

        // GET: Seminars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Seminars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Naziv,Opis,Datum,PopunjenDaNe")] Seminar seminar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(seminar);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /*ex*/)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(seminar);
        }

        // GET: Seminars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminari.FindAsync(id);

            if (seminar == null)
            {
                return NotFound();
            }

            return View(seminar);
        }





        // POST: Seminars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        #region OldBeforeOverPostingFIx
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("SeminarID,Naziv,Opis,Datum,PopunjenDaNe")] Seminar seminar)
        //{
        //    if (id != seminar.SeminarID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(seminar);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SeminarExists(seminar.SeminarID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(seminar);
        //} 
        #endregion

        #region AlternativeForOverPostingFIx
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("SeminarID,Naziv,Opis,Datum,PopunjenDaNe")] Seminar seminar)
        //{
        //    if (id != seminar.SeminarID)
        //    {
        //        return NotFound();
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(seminar);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        catch (DbUpdateException /* ex */)
        //        {
        //            //Log the error (uncomment ex variable name and write a log.)
        //            ModelState.AddModelError("", "Unable to save changes. " +
        //                "Try again, and if the problem persists, " +
        //                "see your system administrator.");
        //        }
        //    }

        //    return View(seminar);
        //}
        #endregion

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var seminarUpdate = await _context.Seminari.FirstOrDefaultAsync(s => s.SeminarID == id);
            if (await TryUpdateModelAsync<Seminar>(seminarUpdate, "", s => s.Naziv, s => s.Opis, s => s.Datum, s => s.PopunjenDaNe))
            {
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                catch (DbUpdateException /* ex */)
                {
                    //Log the error (uncomment ex variable name and write a log.)
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
            return View(seminarUpdate);
        }

        // GET: Seminars/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminari
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.SeminarID == id);

            if (seminar == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }


            return View(seminar);
        }

        // POST: Seminars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seminar = await _context.Seminari.FindAsync(id);

            if (seminar == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                _context.Seminari.Remove(seminar);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /*ex*/)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        #region The create-and-attach approach to HttpPost Delete
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    try
        //    {
        //        Seminar seminarToDelete = new Seminar() { SeminarID = id };
        //        _context.Entry(seminarToDelete).State = EntityState.Deleted;
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (DbUpdateException /* ex */)
        //    {
        //        //Log the error (uncomment ex variable name and write a log.)
        //        return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
        //    }
        //}
        #endregion

        private bool SeminarExists(int id)
        {
            return _context.Seminari.Any(e => e.SeminarID == id);
        }
    }
}
