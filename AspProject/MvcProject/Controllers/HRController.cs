using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HRController : Controller
    {
        private HRManagementEntities db = new HRManagementEntities();

        //
        // GET: /HR/

        public ActionResult Index()
        {
            var tbl_attendance = db.Tbl_Attendance.Include(t => t.Tbl_Manager).Include(t => t.tbl_Register);
            return View(tbl_attendance.ToList());
        }

        //
        // GET: /HR/Details/5

        public ActionResult Details(int id = 0)
        {
            Tbl_Attendance tbl_attendance = db.Tbl_Attendance.Find(id);
            if (tbl_attendance == null)
            {
                return HttpNotFound();
            }
            return View(tbl_attendance);
        }

        //
        // GET: /HR/Create

        public ActionResult Create()
        {
            ViewBag.MID = new SelectList(db.Tbl_Manager, "Mid", "Username");
            ViewBag.Id = new SelectList(db.tbl_Register, "Id", "UserName");
            return View();
        }

        //
        // POST: /HR/Create

        [HttpPost]
        public ActionResult Create(Tbl_Attendance tbl_attendance)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Attendance.Add(tbl_attendance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MID = new SelectList(db.Tbl_Manager, "Mid", "Username", tbl_attendance.MID);
            ViewBag.Id = new SelectList(db.tbl_Register, "Id", "UserName", tbl_attendance.Id);
            return View(tbl_attendance);
        }

        //
        // GET: /HR/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Tbl_Attendance tbl_attendance = db.Tbl_Attendance.Find(id);
            if (tbl_attendance == null)
            {
                return HttpNotFound();
            }
            ViewBag.MID = new SelectList(db.Tbl_Manager, "Mid", "Username", tbl_attendance.MID);
            ViewBag.Id = new SelectList(db.tbl_Register, "Id", "UserName", tbl_attendance.Id);
            return View(tbl_attendance);
        }

        //
        // POST: /HR/Edit/5

        [HttpPost]
        public ActionResult Edit(Tbl_Attendance tbl_attendance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_attendance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MID = new SelectList(db.Tbl_Manager, "Mid", "Username", tbl_attendance.MID);
            ViewBag.Id = new SelectList(db.tbl_Register, "Id", "UserName", tbl_attendance.Id);
            return View(tbl_attendance);
        }

        //
        // GET: /HR/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Tbl_Attendance tbl_attendance = db.Tbl_Attendance.Find(id);
            if (tbl_attendance == null)
            {
                return HttpNotFound();
            }
            return View(tbl_attendance);
        }

        //
        // POST: /HR/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Attendance tbl_attendance = db.Tbl_Attendance.Find(id);
            db.Tbl_Attendance.Remove(tbl_attendance);
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