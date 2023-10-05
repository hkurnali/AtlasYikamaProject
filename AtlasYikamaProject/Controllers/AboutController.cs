using AtlasYikamaProject.DAL.Concrate;
using AtlasYikamaProject.DAL.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtlasYikamaProject.Controllers
{
    public class AboutController : Controller
    {
        Context db=new Context();
        // GET: About
        [Authorize]
        public ActionResult Index()
        {
            var values=db.Abouts.ToList();

            return View( values);
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id) 
        {
            var values = db.Abouts.Find(id);
            return View( values );
        
        }
        [HttpPost]
        public ActionResult UpdateAbout(About about) 
        {
            var values = db.Abouts.Find(about.AboutID);
            values.Image=about.Image;
            values.Title2= about.Title2;
            values.Title1 = about.Title1;
            values.Description=about.Description;
           
            db.SaveChanges();
            return RedirectToAction("Index");
               
        }
    }
}