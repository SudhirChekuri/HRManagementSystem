using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class UserHomeController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View("Profile");
        }

        public ActionResult Leaves()
        {
            return View("Leaves");
        }

        public ActionResult Payslips()
        {
            return View("Payslips");
        }

    }
}
