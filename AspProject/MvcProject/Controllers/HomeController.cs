using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
       
       
        public ActionResult Login()
        {
            if (Request.RequestType == "POST")
            {
                string s1 = Request["UserName"];
                string s2 = Request["Password"];
                if (s1 == "admin" && s2 == "admin")
                {
                    Response.Write("welcome to admin");
                    Response.Redirect("~/UserHome");
                }
                else 
                {
                    Response.Write("Invalid UserName/Password");
                }
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }

    }
}
