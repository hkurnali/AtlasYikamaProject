using AtlasYikamaProject.DAL.Concrate;
using AtlasYikamaProject.DAL.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtlasYikamaProject.Controllers
{
    public class About2Controller : Controller
    {

       Context db=new Context();
        // GET: About
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Abouts2.ToList();

            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateAbout2(int id)
        {
            var values = db.Abouts2.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateAbout2(About2 about2)
        {
            var values = db.Abouts2.Find(about2.About2ID);
            values.Image = about2.Image;
            values.Title2 = about2.Title2;
            values.Title = about2.Title;
            values.Description = about2.Description;
           
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}