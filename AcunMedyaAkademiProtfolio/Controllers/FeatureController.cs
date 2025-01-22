using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiProtfolio.Models;

namespace AcunMedyaAkademiProtfolio.Controllers
{
    public class FeatureController : Controller
    {
        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();
        public ActionResult FeatureList()
        {
            var values = db.Tbl_Feature.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateFeature(Tbl_Feature p)
        {
            db.Tbl_Feature.Add(p);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        public ActionResult DeleteFeature(int id)
        {
            var values = db.Tbl_Feature.Find(id);
            db.Tbl_Feature.Remove(values);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = db.Tbl_Feature.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateFeature(Tbl_Feature p)

        {
            var value = db.Tbl_Feature.Find(p.FeatureId);
            value.FeatureNameSurname = p.FeatureNameSurname;
            value.FeatureDescription = p.FeatureDescription;
            value.FeatureProjectName = p.FeatureProjectName;
            value.FeatureİmageUrl = p.FeatureİmageUrl;
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }

    }
}