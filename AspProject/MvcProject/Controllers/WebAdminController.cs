using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class WebAdminController : Controller
    {
        private HRManagementEntities db = new HRManagementEntities();

        //
        // GET: /WebAdmin/

        public ActionResult Index()
        {
            //var tbl_register = db.tbl_Register.Include(t => t.Tbl_Manager);
            //return View(tbl_register.ToList());
            return View();
        }
        //Admin Login
        public ActionResult AdminLogin()
        {

            return View();
        }
        [HttpPost]

        public ActionResult AdminLogin(string Username, string Password, string JobModel)
        {

            if (JobModel == "2")
            {
                var q1 = from a1 in db.Tbl_HR.ToList()
                         where a1.UserName == Username && a1.Password == Password
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
                        return RedirectToAction("Employee");

                    }
                }

                if (i != 0)
                {
                    //valid hr credentials
                    return Redirect("~/HR/");
                }
                else
                {//invalid hr credentials
                    return RedirectToAction("AdminLogin");
                }

            }
            else if (JobModel == "3")
            {
                var q1 = from m1 in db.Tbl_Manager.ToList()
                         where m1.Username == Username && m1.Password == Password
                         select m1;
                int i = 0;

                foreach (var item in q1)
                {
                    if (item.Username != "")
                    {
                        i = 1;
                    }
                    else
                    {
                        return RedirectToAction("Employee");

                    }
                }

                if (i != 0)
                {//valid manager credentials
                    return Redirect("~/Manager/");
                }
                else
                {//invalid manager credentials
                    return RedirectToAction("AdminLogin");
                }
            }
            else
            {
                if (Username == "Admin" && Password == "Admin")
                {
                    return RedirectToAction("Index");
                }
            }

                return View();
            }
           
            
        

        //
        // GET: /WebAdmin/Employee
        // GET : /WebAdmin/Employee/create
        // GET : /WebAdmin/Employee/Edit/2
        //GET : /WebAdmin/Employee/Details/2
        // GET : /WebAdmin/Employee/Delete/2
        public ActionResult Employee(string operation,string id)
        {
            
            if (operation == "create")
            {
                int Id = Convert.ToInt32(id);
                ViewBag.MId = new SelectList(db.Tbl_Manager, "Mid", "Username");
                return View("EmployeeCreate");
            }
            else if (operation == "Edit")
            {
                int Id = Convert.ToInt32(id);
                tbl_Register tbl_register = db.tbl_Register.Find(Id);
                if (tbl_register == null)
                {
                    return HttpNotFound();
                }
                ViewBag.MId = new SelectList(db.Tbl_Manager, "Mid", "Username", tbl_register.MId);
                return View("EmployeeEdit",tbl_register);
            }
            else if (operation == "Details")
            {
                int Id = Convert.ToInt32(id);
                tbl_Register tbl_register = db.tbl_Register.Find(Id);
                if (tbl_register == null)
                {
                    return HttpNotFound();
                }
                return View("EmployeeDetails",tbl_register);
            }
            else if (operation == "Delete")
            {
                int Id = Convert.ToInt32(id);
                tbl_Register tbl_register = db.tbl_Register.Find(Id);
                if (tbl_register == null)
                {
                    return HttpNotFound();
                }
                return View("EmployeeDelete",tbl_register);
            }
            else
            {
                var tbl_register = db.tbl_Register.Include(t => t.Tbl_Manager);
                return View(tbl_register.ToList());
            }
        }
        //POST :/WebAdmin/Employee/Create
        // POST : /WebAdmin/Employee/Edit/2
        //POST : /WebAdmin/Employee/Delete/2
        [HttpPost]
        public ActionResult Employee(string operation, tbl_Register tbl_register)
        {
            if (operation == "create")
            {
                if (ModelState.IsValid)
                {
                    db.tbl_Register.Add(tbl_register);
                    db.SaveChanges();
                    return RedirectToAction("Employee/");
                }

                ViewBag.MId = new SelectList(db.Tbl_Manager, "Mid", "Username", tbl_register.MId);
                return View(tbl_register);
            }
            else if (operation == "Edit")
            {
                if (ModelState.IsValid)
                {
                    db.Entry(tbl_register).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Employee/");
                }
                ViewBag.MId = new SelectList(db.Tbl_Manager, "Mid", "Username", tbl_register.MId);
                return View(tbl_register);
 
            }
            else if (operation == "Delete")
            {
                // tbl_Register tbl_register = db.tbl_Register.Find(id);
                // db.tbl_Register.Remove(tbl_register);
                db.SaveChanges();
                return RedirectToAction("Employee/");
            }
            else
            {
                return View(tbl_register);
            }
        }

       
      
        // GET: /WebAdmin/Attendence

        public ActionResult Attendence()
        {
            var tbl_attendance = db.Tbl_Attendance.Include(t => t.Tbl_Manager).Include(t => t.tbl_Register);
            return View(tbl_attendance.ToList());
        }
        // GET: /WebAdmin/Payslips

        public ActionResult Payslips()
        {
            var tbl_payslips = db.Tbl_Payslips.Include(t => t.Tbl_Manager).Include(t => t.tbl_Register);
            return View(tbl_payslips.ToList());
        }
        //
        // GET: /WebAdmin/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    tbl_Register tbl_register = db.tbl_Register.Find(id);
        //    if (tbl_register == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tbl_register);
        //}

        //
        // GET: /WebAdmin/Create

        //public ActionResult Create()
        //{
        //    ViewBag.MId = new SelectList(db.Tbl_Manager, "Mid", "Username");
        //    return View();
        //}


      

        //
        // POST: /WebAdmin/Create

        //[HttpPost]
        //public ActionResult Create(tbl_Register tbl_register)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.tbl_Register.Add(tbl_register);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.MId = new SelectList(db.Tbl_Manager, "Mid", "Username", tbl_register.MId);
        //    return View(tbl_register);
        //}

       
       // GET : WebAdmin/Manager/Create
        //GET : WebAdmin/Manager/Edit/2
        // GET : WebAdmin/Manager/Detail/2
        // GET : WebAdmin/Manager/Delete/2
        public ActionResult Managers(string operation, string id)
        {
           
            if (operation == "create")
            {
                return View("ManagerCreate");
            }
            else if (operation == "Edit")
            {
                int Id = Convert.ToInt32(id);
                Tbl_Manager tbl_manager = db.Tbl_Manager.Find(Id);
                if (tbl_manager == null)
                {
                    return HttpNotFound();
                }
                return View("ManagerEdit",tbl_manager);
            }
            else if (operation == "Delete")
            {
                int Id = Convert.ToInt32(id);
                Tbl_Manager tbl_manager = db.Tbl_Manager.Find(Id);

                if (tbl_manager == null)
                {
                    return HttpNotFound();
                }
                return View("managerDelete", tbl_manager);
            }
            else if (operation == "Details")
            {
                int Id = Convert.ToInt32(id);
                Tbl_Manager tbl_manager = db.Tbl_Manager.Find(Id);
                if (tbl_manager == null)
                {
                    return HttpNotFound();
                }
                return View("ManagerDetails", tbl_manager);
            }
            else
            {
                return View(db.Tbl_Manager.ToList());
            }
            
        }
        //POST:WebAdmin/Managers/Create
        //POST:WebAdmin/Managers/Edit
        //POST:WebAdmin/Manager/Delete
        [HttpPost]
        
        public ActionResult Managers(string operation,  Tbl_Manager Tbl_Manager)
        {
            if (operation == "create")
            {
                if (ModelState.IsValid)
                {
                    db.Tbl_Manager.Add(Tbl_Manager);
                    db.SaveChanges();
                    return RedirectToAction("Managers/");
                }

                return View(Tbl_Manager);
            }
            else if (operation == "Edit")
            {
                if (ModelState.IsValid)
                {
                    db.Entry(Tbl_Manager).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Managers/");
                }
                return View(Tbl_Manager);
            }
            else if (operation == "Delete")
            {

                //Tbl_Manager tbl_manager = db.Tbl_Manager.Find(id);
                //db.Tbl_Manager.Remove(tbl_manager);
                db.SaveChanges();
                return RedirectToAction("Managers/");

            }
            else
            {
                return View(Tbl_Manager);
            }
            
        }

        // GET: /WebAdmin/HR
        // GET: /WebAdmin/HR/Create
        // GET: /WebAdmin/HR/Edit/2
        // GET: /WebAdmin/HR/Delete/2
        // GET:/WebAdmin/HR/Details/2
        public ActionResult HR(string operation,string id)
        {
            if (operation == "create")
            {
                return View("HRCreate");
            }
            else if (operation == "Edit")
            {
                int Id = Convert.ToInt32(id);

                Tbl_HR tbl_hr = db.Tbl_HR.Find(Id);
                if (tbl_hr == null)
                {
                    return HttpNotFound();
                }
                return View("HREdit",tbl_hr);
            }
            else if (operation == "Delete")
            {
                int Id = Convert.ToInt32(id);
                Tbl_HR tbl_hr = db.Tbl_HR.Find(Id);
                if (tbl_hr == null)
                {
                    return HttpNotFound();
                }
                return View("HRDelete",tbl_hr);
            }
            else if (operation == "Details")
            {
                int Id = Convert.ToInt32(id);
                Tbl_HR tbl_hr = db.Tbl_HR.Find(Id);
                if (tbl_hr == null)
                {
                    return HttpNotFound();
                }
                return View("HRDetails",tbl_hr);
            }
            else
            {
                return View(db.Tbl_HR.ToList());
            }
        }
        // POST:WebAdmin/HR/Create
        // POST:WebAdmin/HR/Edit/2
        //POST : WebAdmin/HR/Delete/2
        [HttpPost]
        public ActionResult HR(string operation,Tbl_HR tbl_hr)
        {
            if (operation == "create")
            {
                if (ModelState.IsValid)
                {
                    db.Tbl_HR.Add(tbl_hr);
                    db.SaveChanges();
                    return RedirectToAction("HR/");
                }

                return View("HRCreate",tbl_hr);

            }
            else if (operation == "Edit")
            {
                if (ModelState.IsValid)
                {
                    db.Entry(tbl_hr).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("HR/");
                }
                return View("HREdit",tbl_hr);
            }
            else if (operation == "Delete")
            {
                //Tbl_HR tbl_hr = db.Tbl_HR.Find(id);
                // db.Tbl_HR.Remove(tbl_hr);
                db.SaveChanges();
                return RedirectToAction("HR/");
            }
            else
            {
                return View(tbl_hr);
            }
 
        }
       
        //
        // GET: /WebAdmin/Edit/5

        //public ActionResult Edit(int id = 0)
        //{
        //    tbl_Register tbl_register = db.tbl_Register.Find(id);
        //    if (tbl_register == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.MId = new SelectList(db.Tbl_Manager, "Mid", "Username", tbl_register.MId);
        //    return View(tbl_register);
        //}

        //
        // POST: /WebAdmin/Edit/5

        //[HttpPost]
        //public ActionResult Edit(tbl_Register tbl_register)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(tbl_register).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.MId = new SelectList(db.Tbl_Manager, "Mid", "Username", tbl_register.MId);
        //    return View(tbl_register);
        //}

        //
        // GET: /WebAdmin/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tbl_Register tbl_register = db.tbl_Register.Find(id);
            if (tbl_register == null)
            {
                return HttpNotFound();
            }
            return View(tbl_register);
        }

        //
        // POST: /WebAdmin/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Register tbl_register = db.tbl_Register.Find(id);
            db.tbl_Register.Remove(tbl_register);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}