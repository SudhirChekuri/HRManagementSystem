using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class WebAdminController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Employees()
        {
            return View("Employees");
        }

        public ActionResult Manager()
        {
            return View("Manager");
        }

        public ActionResult HR()
        {
            return View("HR");
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
