using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeminarCore2.Data;
using SeminarCore2.Models;
using SeminarCore2.Models.SeminarViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarCore2.Controllers
{
    public class HomeController : Controller
    {
        private readonly MojContext _context;

        public HomeController(MojContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public async Task<ActionResult> About()
        {
            IQueryable<EnrollmentDateGroup> data =
            from sem in _context.Seminari
            select new EnrollmentDateGroup()
            {
                DatumSeminara = sem.Datum,
                StudentCount = sem.Predbiljezbe.Count(),
                NazivSeminara = sem.Naziv
            };

            return View(await data.AsNoTracking().ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
