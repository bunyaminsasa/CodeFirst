using Level.DbContexts;
using Level.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Level.Controllers
{
    public class HomeController : Controller
    {
        MSSQLContext db;
        public HomeController(MSSQLContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Tours = db.Tour.Include(t => t.Country).ToList();
            homeVM.Countries = db.Country.ToList();
            homeVM.News = db.News.Include(i=> i.Category).ToList();
            return View(homeVM);
        }

        [HttpPost, Route("iletisim"), ValidateAntiForgeryToken]
        public IActionResult Contact(HomeVM _model)
        {
            if (ModelState.IsValid)
            {
                db.Contact.Add(_model.Contact);
                db.SaveChanges();
                TempData["iletisimMesaj"] = "Bilgileriniz Eklendi";
            }

            else TempData["iletisimMesaj"] = "Geçersiz Veri gönderimi";
            return RedirectToAction("Index");
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
