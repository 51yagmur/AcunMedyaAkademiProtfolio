using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiProtfolio.Models;

namespace AcunMedyaAkademiProtfolio.Controllers
{
    public class CategoryController : Controller
    {
       DbDominicPortfolioEntities db=new DbDominicPortfolioEntities();
        public ActionResult CategoryList()
        {
            var values=db.Tbl_Category.ToList();
            return View(values);
        }
        //EKLEME İŞLEMİ
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Tbl_Category p)
        {
            db.Tbl_Category.Add(p);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        //EKLEME İŞLEMİ

        public ActionResult DeleteCategory(int id) 
        {
            var values = db.Tbl_Category.Find(id);
            db.Tbl_Category.Remove(values);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value= db.Tbl_Category.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateCategory(Tbl_Category p)
        {
            var value = db.Tbl_Category.Find(p.CategoryId);
            value.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
       
    }
}