using AtlasYikamaProject.DAL.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtlasYikamaProject.Controllers
{
    public class DefaultController : Controller
    {
        Context db=new Context();
        public ActionResult Index()
        {
            
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialCallBack()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }
        public PartialViewResult PartialProgress()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout2()
        {
            return PartialView();
        }
        public PartialViewResult PartialService()
        {
            var values = db.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        public PartialViewResult PartialComment()
        {
            var values = db.Comments.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}