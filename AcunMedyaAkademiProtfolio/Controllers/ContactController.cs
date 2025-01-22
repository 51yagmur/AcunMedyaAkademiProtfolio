using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiProtfolio.Models;

namespace AcunMedyaAkademiProtfolio.Controllers
{
    public class ContactController : Controller
       
    {
        DbDominicPortfolioEntities db=new DbDominicPortfolioEntities();
        public ActionResult ContactList()
        {
            var values = db.Tbl_Contact.ToList();
            return View(values);

        }
        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult SendMessage(Tbl_Contact c)
        {
            c.SendDate = DateTime.Now;
            c.IsRead = false;
            db.Tbl_Contact.Add(c);
            db.SaveChanges();
            return Redirect("/Default/Index#Contact");
        }

        public ActionResult msgContact(int id)
        {
            var value = db.Tbl_Contact.Find(id);
            return View(value);
        }

        public ActionResult DeleteContact(int id)
        {
            var values = db.Tbl_Contact.Find(id);
            db.Tbl_Contact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}