using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlexaderKrasowski.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "About Alexander Krasowski's home page.";

            return View();
        }

        public ActionResult Contact()
        {
            // ViewBag.Message = "Contact Info.";
            ViewBag.Message = "Contact Info.";

            string email = "krasowskian@gmail.com";
               email = "mailto:" + String.Concat(email.Select(c => "&#" + ((int)c).ToString() + ";").ToArray());

            ViewBag.Description = email;


        
            return View();
        }

        //public ActionResult ContactEmail()
        //{
        //    // ViewBag.Message = "Contact Info.";

        //    string email = "krasowskian@gmail.com";
        //    email = String.Concat(email.Select(c => "&#" + ((int)c).ToString() + ";").ToArray());

        //    return email;
        //}

        public ActionResult Projects()
        {
            //ViewBag.Message = "Project Info: Coming Soon!";

            return View();
        }
    }
}