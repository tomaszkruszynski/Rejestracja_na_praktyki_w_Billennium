using Rejestracja_na_praktyki_w_Billennium.DAL;
using Rejestracja_na_praktyki_w_Billennium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rejestracja_na_praktyki_w_Billennium.Controllers
{
    public class HomeController : Controller
    {

        private PraktykiContext db = new PraktykiContext(); 
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Praktykant model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            db.Praktykant.Add(model);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}