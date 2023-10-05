using AtlasYikamaProject.DAL.Concrate;
using AtlasYikamaProject.DAL.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AtlasYikamaProject.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        Context db=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Services.ToList();

            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var values = db.Services.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateService(Service service)
        {
            var values = db.Services.Find(service.ServiceID);
          
            values.Description1 = service.Description1;
            values.Description2 = service.Description2;
            values.Description3 = service.Description3;

            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}