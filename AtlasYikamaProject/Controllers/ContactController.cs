using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AtlasYikamaProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Adsoyad=null, string Mail=null, string Telefon=null,string Mesaj=null)
        {
            if(Adsoyad!=null&& Mail != null && Telefon != null && Mesaj != null) 
            {
                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.EnableSsl = true;
                WebMail.UserName = "aatlasyyikama@gmail.com";
                WebMail.Password = "j m o z w q v s g y w v s a d y";
                WebMail.SmtpPort = 587;
                WebMail.Send("aatlasyyikama@gmail.com", Adsoyad, Telefon+"-"+Mail+"-"+Mesaj);
                ViewBag.uyari = "Mesajınız Gönderilmiştir.";
            }
            else 
            {
                ViewBag.uyari = "Hata Oluştu Tekrar Deneyiniz.";
            }
            return View();
        }

    }
}