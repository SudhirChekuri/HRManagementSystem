using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HRController : Controller
    {
        //
        // GET: /HR/

        public ActionResult Index()
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
