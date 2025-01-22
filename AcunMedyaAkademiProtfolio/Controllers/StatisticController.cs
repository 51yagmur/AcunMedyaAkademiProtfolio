using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiProtfolio.Models;

namespace AcunMedyaAkademiProtfolio.Controllers
{
    public class StatisticController : Controller
    {
        //sınıfta nesne türetmek veritabanında tablo ve propertylere ulaşmak için
        DbDominicPortfolioEntities db=new DbDominicPortfolioEntities();

        public ActionResult Index()
        {
            ViewBag.categorysayisi = db.Tbl_Category.Count();
            ViewBag.projesayisi=db.Tbl_Project.Count();
            return View();
        }
    }
}