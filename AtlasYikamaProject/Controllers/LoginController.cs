using AtlasYikamaProject.DAL.Concrate;
using AtlasYikamaProject.DAL.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AtlasYikamaProject.Controllers
{
    public class LoginController : Controller
    {  Context db=new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var valius = db.Admins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (valius != null)
            {

                FormsAuthentication.SetAuthCookie(valius.Username, false);
                Session["username"] = valius.Username.ToString();
                return RedirectToAction("Index", "Service");

            }
            return View();
        }
    }
}