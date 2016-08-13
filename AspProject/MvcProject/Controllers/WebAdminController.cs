using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class WebAdminController : Controller
    {
        //
        // GET: /WebAdmin/
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Home()
        //{
        //    return View();
        //}
        public ActionResult Employee()
        {
            return View();
        }
        public ActionResult Manager()
        {
            return View();
        }
        public ActionResult HR()
        {
            return View();
        }
        public ActionResult Attendance()
        {
            return View();
        }
        public ActionResult Payslips()
        {
            return View();
        }

    }
}
