using AtlasYikamaProject.DAL.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtlasYikamaProject.DAL.Concrate;

namespace AtlasYikamaProject.Controllers
{
    public class CommentController : Controller
    {
        Context db = new Context();
        // GET: About
        public ActionResult Index()
        {
            var values = db.Comments.ToList();

            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateComment(int id)
        {
            var values = db.Comments.Find(id);
            return View(values);

        }
        [HttpPost]
        public ActionResult UpdateComment(Comment comment)
        {
            var values = db.Comments.Find(comment.CommentID);
            values.Image = comment.Image;

            
            values.Description = comment.Description;

            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}