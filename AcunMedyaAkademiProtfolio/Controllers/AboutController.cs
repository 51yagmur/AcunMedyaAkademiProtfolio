using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiProtfolio.Models;

namespace AcunMedyaAkademiProtfolio.Controllers
{
    public class AboutController : Controller
    {
        DbDominicPortfolioEntities db=new DbDominicPortfolioEntities();

        // GET: About
        public ActionResult AboutList()

        {
            var values= db.Tbl_About.ToList();

            return View(values);
        }
        [HttpGet]

        public ActionResult CreaateAbout()
        {
            return View();

        }
        [HttpPost]

        public ActionResult CreateAbout(Tbl_About p)
        { 
            db.Tbl_About.Add(p);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public ActionResult DeleteAbout(int id) 
        { 
          var values=db.Tbl_About.Find(id);
            db.Tbl_About.Remove(values);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = db.Tbl_About.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateAbout(Tbl_About p)
        {
            var value = db.Tbl_About.Find(p.AboutId);
            value.AboutTitle = p.AboutTitle;
            value.AboutDescription = p.AboutDescription;
            value.AboutİmgUrl = p.AboutİmgUrl;
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }

    }
}