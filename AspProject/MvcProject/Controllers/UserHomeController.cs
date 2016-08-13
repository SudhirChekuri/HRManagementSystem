using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class UserHomeController : Controller
    {
        //
        // GET: /UserHome/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult Leaves()
        {
            return View();
        }
        public ActionResult Payslips()
        {
            return View();
        }

    }
}
