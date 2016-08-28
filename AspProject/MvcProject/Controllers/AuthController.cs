using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcProject.Models;

namespace MvcProject.Controllers
{

    public class AuthController : Controller
    {
        private HRManagementEntities db = new HRManagementEntities();

        //
        // GET: /Account/Register

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register

        [HttpPost]
        public ActionResult Register(tbl_Register model)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user

                //WebSecurity.CreateUserAndAccount(model.UserName, model.Password);
                //WebSecurity.Login(model.UserName, model.Password);
                model.Status = "I";
                // model.CreatedTime = System.DateTime.Now;
                db.tbl_Register.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index", "Auth");
            }
            return View();

        }

        // If we got this far, something failed, redisplay form



        //
        // GET: /Auth/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //
        [HttpPost]
        public ActionResult Index(String Uname, String Pwd)
        {
            var q1 = from a1 in db.tbl_Register.ToList()
                     where a1.UserName == Uname && a1.Password == Pwd
                     select a1;
            int i = 0;

            foreach (var item in q1)
            {
                if (item.UserName != "")
                {
                    i = 1;
                }
                else
                {

                    return View("Profile");

                }
            }
            if (q1 != null)
            {
                if (i != 0)
                {
                    var EmpId = from a in db.tbl_Register.ToList()
                                where a.UserName == Uname
                                select a.Id;
                    foreach (var item in EmpId)
                    {
                        //saving employee id to use after login in all pages
                        Session["EmployeeId"] = item;
                    }

                    //Valid login credentials
                    return Redirect("~/User/");
                    
                }
                else
                {
                    //invalid login credentials
                    return Redirect("~/Auth/Index");
                }

            }
            else
            {
                return View("Index");
            }
          

        }

    }
}
