using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtlasYikamaProject.Controllers
{
    public class BlogPageController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
    }
}