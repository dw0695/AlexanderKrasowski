using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlexaderKrasowski.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        //         // GET: /Store/ 

        public string Index() {
            //var index = "Hello from Store.Index()";
            //return View(index);

            return "Hello from Store.Index()";
        }
      

        //         // GET: /Store/Browse 

   
        public string About()
        {
            //var about = "About Alexander Krasowski's home page.";

            //return View(about);

            return "About Alexander Krasowski's home page";
        }

        public string Contact()
        {
            //var contact = "Contact Info.";

            //return View(contact);

            return "Contact Info";
        }

        public string Projects()
        {
            //var projects = "Project Info.";

            //return View(projects);

            return "Project Info";
        }
    }
}