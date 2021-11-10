using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SeminarCore2.Data;
using SeminarCore2.Extra;
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
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber, string currentStatus, string status, string currentSearchCategory, string search_category)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["ImeSortParm"] = string.IsNullOrEmpty(sortOrder) ? "ime_desc" : "";
            ViewData["PrezimeSortParm"] = sortOrder == "prezime_asc" ? "prezime_desc" : "prezime_asc";
            ViewData["NazivSortParm"] = sortOrder == "name_asc" ? "name_desc" : "name_asc";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;

            }

            if (status != null || search_category != null)
            {
                pageNumber = 1;
            }
            else
            {
                status = currentStatus;
                search_category = currentSearchCategory;
            }

            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentStatus"] = status;
            ViewData["CurrentSearchCategory"] = search_category;


            var predbiljezbe = _context.Predbiljezbe
                .Include(p => p.Seminar)
                .AsNoTracking();


            if (!string.IsNullOrEmpty(search_category) && !String.IsNullOrEmpty(searchString))
            {
                switch (search_category)
                {
                    case "Ime":
                        predbiljezbe = predbiljezbe.Where(x => x.Ime.Contains(searchString));
                        break;
                    case "Prezime":
                        predbiljezbe = predbiljezbe.Where(x => x.Prezime.Contains(searchString));
                        break;
                    default:
                        break;
                }

            }

            #region trash
            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    predbiljezbe = predbiljezbe.Where(s =>
            //                              s.Ime.Contains(searchString)
            //                           || s.Prezime.Contains(searchString)
            //                           || s.Adresa.Contains(searchString)
            //                           );
            //} 
            #endregion

            #region DropDownSearchCategory
            var options_1 = new SelectListItem[]{
                new SelectListItem() { Text = "Ime", Value = "Ime" },
                new SelectListItem() { Text = "Prezime", Value = "Prezime" },
            };

            ViewBag.categoryDropDown = new SelectList(options_1, "Value", "Text", search_category);
            #endregion

            #region DropDownFilterStatus
            var options = new SelectListItem[]{
                new SelectListItem() { Text = "Svi", Value = ""},
                new SelectListItem() { Text = "Odobreni", Value = "Odobreni" },
                new SelectListItem() { Text = "Odbijeni", Value = "Odbijeni" },
                new SelectListItem() { Text = "Neobradjeni", Value = "Neobradjeni" }
            };

            ViewBag.statusDropDown = new SelectList(options, "Value", "Text", status);


            if (!string.IsNullOrEmpty(status))
            {
                //predbiljezbe = predbiljezbe.Where(x => x.StatusDaNe == (status == "Odobreni"));

                #region 1
                //predbiljezbe = predbiljezbe.Where(x => (x.StatusDaNe == false ? "Odbijeni" : !x.StatusDaNe.HasValue ? "Neobradjeni" : "Odobreni").Equals(status)); 
                #endregion

                #region 2
                //bool? test = (status == "Neobradjeni") ? (test = null) : (status == "Odobreni");
                //predbiljezbe = predbiljezbe.Where(x => x.StatusDaNe == test); 
                #endregion

                #region 3

                predbiljezbe = predbiljezbe.Where(x => 
                x.StatusDaNe == ((status == "Odobreni") ? true : 
                    ((status == "Neobradjeni") ?
                    default(bool?) /*ili (bool?)null*/ 
                    : 
                    false))
                ); 

                #endregion

                #region TestGood
                //bool? what = (status == "Odobreni") ? true : ((status == "Neobradjeni") ? (bool?)null : false);
                //string test2 = (what == false ? "Odbijeni" : !what.HasValue ? "Neobradjeni" : "Odobreni"); 
                #endregion

                #region Nez
                //b = status?.Equals("Neobradjeni") ?? null; 
                #endregion
            }

            #endregion


            switch (sortOrder)
            {
                case "ime_desc":
                    predbiljezbe = predbiljezbe.OrderByDescending(s => s.Ime);
                    break;
                case "prezime_desc":
                    predbiljezbe = predbiljezbe.OrderByDescending(s => s.Prezime);
                    break;
                case "prezime_asc":
                    predbiljezbe = predbiljezbe.OrderBy(s => s.Prezime);
                    break;
                case "name_desc":
                    predbiljezbe = predbiljezbe.OrderByDescending(s => s.Seminar.Naziv);
                    break;
                case "name_asc":
                    predbiljezbe = predbiljezbe.OrderBy(s => s.Seminar.Naziv);
                    break;
                default:
                    predbiljezbe = predbiljezbe.OrderBy(s => s.Ime);
                    break;
            }

            int pageSize = 50;
            return View(await PaginatedList<Predbiljezba>.CreateAsync(predbiljezbe.AsNoTracking(), pageNumber ?? 1, pageSize));
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
        public IActionResult Create(int? id)
        #region Kanta
        //public async Task<IActionResult> Create(int? id) 
        #endregion
        {
            var model = new Predbiljezba()
            {
                Datum = DateTime.Now,
                SeminarID = id ?? -1
            };

            #region Kanta

            //if (model.SeminarID != -1)
            //{
            //    var seminar = await _context.Seminari.FindAsync(model.SeminarID);

            //    if (seminar == null)
            //    {
            //        return NotFound();
            //    }
            //} 
            #endregion

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
