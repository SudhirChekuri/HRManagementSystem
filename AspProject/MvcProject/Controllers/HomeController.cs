using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Login()
        {
           if(Request.RequestType=="POST")
           {
               string s1=Request["Uname"];
               string s2=Request["pwd"];
               if (s1 == "balaji" && s2 == "balaji")
               {
                   Response.Redirect("~/UserHome/Index");
                   Response.Write("Welcome to"+s1);
                   
               }
               }
            return View("Login");
        }

        public ActionResult AboutUs()
        {
            return View("AboutUs");
        }

        public ActionResult ContactUs()
        {
            return View("ContactUs");
        }

    }
}
