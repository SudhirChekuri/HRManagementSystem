using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class ManagerController : Controller
    {
        //
        // GET: /Manager/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Employees()
        {
            return View();
        }
        public ActionResult Leaves()
        {
            return View();
        }

    }
}
