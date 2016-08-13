using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HRController : Controller
    {
       

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Attendance()
        {
            return View("Attendance");
        }

        public ActionResult Payslips()
        {
            return View("Payslips");
        }

    }
}
