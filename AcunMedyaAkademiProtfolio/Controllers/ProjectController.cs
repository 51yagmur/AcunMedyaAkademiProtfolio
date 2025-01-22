using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiProtfolio.Models;

namespace AcunMedyaAkademiProtfolio.Controllers
{
    public class ProjectController : Controller
    {
      DbDominicPortfolioEntities db=new DbDominicPortfolioEntities();
        public ActionResult ProjectList()
        {
            var values=db.Tbl_Project.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            List<SelectListItem> values = (from x in db.Tbl_Category.ToList()select new SelectListItem
            {
                Text=x.CategoryName,
                Value=x.CategoryId.ToString()
                

            }).ToList();
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(Tbl_Project p)
        {
            db.Tbl_Project.Add(p);
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }

        public ActionResult DeleteProject(int id)
        {
            var values = db.Tbl_Project.Find(id);
            db.Tbl_Project.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        { 
       
            List<SelectListItem> values1 = (from x in db.Tbl_Category.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()


                                           }).ToList();
            ViewBag.v = values1;

            var value=db.Tbl_Project.Find(id);
            return View(value);

                }
        [HttpPost]
        public ActionResult UpdateProject(Tbl_Project p)

        {
            var value= db.Tbl_Project.Find(p.ProjectId);
            value.Description= p.Description;
            value.İmageUrl = p.İmageUrl;
            value.CategoryId= p.CategoryId;
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }


    }
}