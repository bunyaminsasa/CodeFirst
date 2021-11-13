using Level.DbContexts;
using Level.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Level.Controllers
{
    public class TourController : Controller
    {
        MSSQLContext db;
        public TourController(MSSQLContext _db)
        {
            db = _db;
        }

        [Route("/ulke/{name}")]
        public IActionResult CountryPages(string name)
        {
            return View();
            if (!string.IsNullOrEmpty(name))
            {
                Country c = db.Country.Include(x => x.Tours).FirstOrDefault(z => z.Name == name);
                if (c != null) return View(c);
            }
            return RedirectToAction("/");
        }

        [Route("/tur/{name}")]
        public IActionResult Detail(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Tour t = db.Tour.Include(i=>i.Country).FirstOrDefault(f => f.Name == name);
                if (t != null) return View(t);
            }
            return RedirectToAction("/");
        }
    }
}
