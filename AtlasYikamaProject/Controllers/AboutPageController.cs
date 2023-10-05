using AtlasYikamaProject.DAL.Concrate;
using AtlasYikamaProject.DAL.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtlasYikamaProject.Controllers
{
    public class AboutPageController : Controller
    {
        Context db=new Context();
      
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAbout() 
        {
            var values = db.AboutPages.ToList();
          return PartialView(values);
        }
        public ActionResult AdminAboutPage()
        {
            var values =db.AboutPages.ToList();

            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateAboutPage(int id) 
        {
            var values = db.AboutPages.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAboutPage(AboutPage aboutPage) 
        {
            var values = db.AboutPages.Find(aboutPage.AboutPageID);
            values.Description = aboutPage.Description;
            values.Description2 = aboutPage.Description2;
            values.Title2 = aboutPage.Title2;
            values.Title=aboutPage.Title;
            db.SaveChanges();
            return RedirectToAction("AdminAboutPage", "AboutPage");
        
        }
    }
}