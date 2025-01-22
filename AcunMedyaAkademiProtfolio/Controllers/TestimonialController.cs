using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiProtfolio.Models;

namespace AcunMedyaAkademiProtfolio.Controllers
{
    public class TestimonialController : Controller
    {
        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();
        public ActionResult TestimonialList()
        {
            var values = db.Tbl_Testimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(Tbl_Testimonial p)
        {
            db.Tbl_Testimonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.Tbl_Testimonial.Find(id);
            db.Tbl_Testimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.Tbl_Testimonial.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Tbl_Testimonial p)

        {
            var value = db.Tbl_Testimonial.Find(p.TestimonialId);
            value.TestimonialTitle = p.TestimonialTitle;
            value.TestimonialDescription = p.TestimonialDescription;
            value.TestimonialNameSurname = p.TestimonialNameSurname;
            value.TestimonialİmageUrl = p.TestimonialİmageUrl;
            value.Testimonialjob = p.Testimonialjob;
            value.TestimonialStatus = p.TestimonialStatus;
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}