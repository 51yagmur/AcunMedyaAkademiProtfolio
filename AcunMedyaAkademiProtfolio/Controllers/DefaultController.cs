using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiProtfolio.Models;

namespace AcunMedyaAkademiProtfolio.Controllers
{
   
    public class DefaultController : Controller
    {
       
      DbDominicPortfolioEntities db=new DbDominicPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
                }
        //dinamikleştirme
        public PartialViewResult FeaturePartial()
        {
            var values=db.Tbl_Feature.ToList();

            return PartialView(values);
        }
        public PartialViewResult AboutPartial()
        {
            var values=db.Tbl_About.ToList();
            return PartialView(values);
        }
        public PartialViewResult ServicePartial()
        {
            var values = db.Tbl_Service.ToList();
            return PartialView(values);
        }
        public PartialViewResult TestimonialPartial()
        {
            var values = db.Tbl_Testimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult ProjectPartial()
        {
            var values = db.Tbl_Project.ToList();
            return PartialView(values);
        }
        public PartialViewResult ContactPartial()
        {
            var values = db.Tbl_Contact.ToList();
            return PartialView(values);
        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}