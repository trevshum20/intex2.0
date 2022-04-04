using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Intex2.Models;
using Microsoft.EntityFrameworkCore;

namespace Intex2.Controllers
{
    public class HomeController : Controller
    {
        private CrashDbContext _context { get; set; }

        public HomeController(CrashDbContext temp)
        {
            _context = temp;
        }

        public DbSet<utah_crashes> Crashes { get; set; }
        public DbSet<Severity> Severities { get; set; }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Summary()
        {
            var blah = _context.Crashes.ToList();

            return View(blah);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = _context.Severities.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Add(utah_crashes uc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uc);
                _context.SaveChanges();
                return View("Confirmation", uc);
            }
            else
            {
                ViewBag.Categories = _context.Severities.ToList();


                return View(uc);
            }
        }

        [HttpGet]
        public IActionResult Edit(string CrashId)
        {
            var crash = _context.Crashes.Single(x => x.CRASH_ID == CrashId);

            return View("Edit", crash);
        }

        [HttpPost]
        public IActionResult Edit(utah_crashes editInfo)
        {
            _context.Update(editInfo);
            _context.SaveChanges();

            return RedirectToAction("Summary");
        }

        public IActionResult Details(string CrashId)
        {
            var crash = _context.Crashes.Single(x => x.CRASH_ID == CrashId);

            return View("Details", crash);
        }

        public IActionResult Delete(string CrashId)
        {
            var crash = _context.Crashes.Single(x => x.CRASH_ID == CrashId);
            _context.Remove(crash);
            _context.SaveChanges();

            return RedirectToAction("Summary");
        }
    }
}
