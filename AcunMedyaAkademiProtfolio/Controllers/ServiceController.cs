using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiProtfolio.Models;

namespace AcunMedyaAkademiProtfolio.Controllers
{
    public class ServiceController : Controller
    {
        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();
        public ActionResult ServiceList()
        {
            var values = db.Tbl_Service.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(Tbl_Service p)
        {
            db.Tbl_Service.Add(p);
            db.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public ActionResult DeleteService(int id)
        {
            var values = db.Tbl_Service.Find(id);
            db.Tbl_Service.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ServiceList");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = db.Tbl_Service.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateService(Tbl_Service p)

        {
            var value = db.Tbl_Service.Find(p.ServiceId);
            value.ServiceTitle = p.ServiceTitle;
            value.ServiceDescription = p.ServiceDescription;
            value.ServiceİmageUrl = p.ServiceİmageUrl;
            db.SaveChanges();
            return RedirectToAction("ServiceList");

        }

    }
}