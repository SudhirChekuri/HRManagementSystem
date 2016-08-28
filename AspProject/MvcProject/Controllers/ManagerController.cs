using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class ManagerController : Controller
    {
        private HRManagementEntities db = new HRManagementEntities();

        //
        // GET: /Manager/

        public ActionResult Index()
        {
            return View();
            //return View(db.Tbl_Manager.ToList());
        }
        // GET: /Manager/Employees
        public ActionResult Employees()
        {
            return View(db.tbl_Register.ToList());
        }
        // POST: /Manager/Employees
        [HttpPost]
        public ActionResult Employees(string SerachTerm)
        {
            List<tbl_Register>Users;
            if (string.IsNullOrEmpty(SerachTerm))
            {
                Users = db.tbl_Register.ToList();
                //return View(db.tbl_Register.ToList());
            }
            else
            {
                 Users=db.tbl_Register.Where(u=>u.UserName.StartsWith(SerachTerm)).ToList();
            }
            return View(Users);
        }
        // GET: Manager/Leaves
        public ActionResult Leaves(string Operation, string ID)
        {
            int id = Convert.ToInt32(ID);
            if (Operation == "Approve")
            {
                Tbl_Leaves tbl_leaves = db.Tbl_Leaves.Find(id);
                if (tbl_leaves == null)
                {
                    return HttpNotFound();
                }
                        return View(tbl_leaves);
            }
            if (Operation == "Reject")
            {
                Tbl_Leaves tbl_leaves = db.Tbl_Leaves.Find(id);
                if (tbl_leaves == null)
                {
                    return HttpNotFound();
                }
                return View(tbl_leaves);
            }
            else
            {
                return View(db.Tbl_Leaves.ToList());
            }
        }
        //POST: Manager/Leaves
        [HttpPost]
        public ActionResult Leaves(string Operation , Tbl_Leaves tbl_leaves)
        {
            if (Operation == "Approve")
            {
                if (ModelState.IsValid)
                {
                    db.Entry(tbl_leaves).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(tbl_leaves);
            }
                //if (Operation == "Reject")
            else 
            {
                if (ModelState.IsValid)
                {
                    db.Entry(tbl_leaves).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(tbl_leaves);
            }
        }

        // GET: Manager/
        //public ActionResult Employee(string Operation, string ID)
        //{
        //    int id = Convert.ToInt32(ID);
        //    if (Operation == "Create")
        //    {
        //        return View();
        //    }
        //    else if (Operation == "Edit")
        //    {
        //        Tbl_Manager tbl_manager = db.Tbl_Manager.Find(id);
        //        if (tbl_manager == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(tbl_manager);
        //    }
        //    else if (Operation == "Details")
        //    {
        //        Tbl_Manager tbl_manager = db.Tbl_Manager.Find(id);
        //        if (tbl_manager == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(tbl_manager);
        //    }
        //    else if (Operation == "Delete")
        //    {
        //        Tbl_Manager tbl_manager = db.Tbl_Manager.Find(id);
        //        if (tbl_manager == null)
        //        {
        //            return HttpNotFound();
        //        }
        //        return View(tbl_manager);
        //    }
        //    else 
        //    {
        //        return View(db.Tbl_Manager.ToList());
        //    }
            
        //}
        //// POST: Manager/
        //[HttpPost]
        //public ActionResult Employee(string Operation, string ID, Tbl_Manager tbl_manager)
        //{
        //    int id = Convert.ToInt32(ID);
        //    if (Operation == "Create")
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.Tbl_Manager.Add(tbl_manager);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }

        //        return View(tbl_manager);
        //    }
        //    else if (Operation == "Edit")
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            db.Entry(tbl_manager).State = EntityState.Modified;
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }
        //        return View(tbl_manager);
        //    }
        //    //if (Operation == "Delete")
        //    else 
        //    {
        //        Tbl_Manager tbl_dmanager = db.Tbl_Manager.Find(id);
        //        db.Tbl_Manager.Remove(tbl_dmanager);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
            

        //}
        //
        // GET: /Manager/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    Tbl_Manager tbl_manager = db.Tbl_Manager.Find(id);
        //    if (tbl_manager == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tbl_manager);
        //}

        //
        // GET: /Manager/Create

        //public ActionResult Create()
        //{
        //    return View();
        //}

        //
        // POST: /Manager/Create

        //[HttpPost]
        //public ActionResult Create(Tbl_Manager tbl_manager)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Tbl_Manager.Add(tbl_manager);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(tbl_manager);
        //}

        //
        // GET: /Manager/Edit/5

        //public ActionResult Edit(int id = 0)
        //{
        //    Tbl_Manager tbl_manager = db.Tbl_Manager.Find(id);
        //    if (tbl_manager == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tbl_manager);
        //}

        //
        // POST: /Manager/Edit/5

        //[HttpPost]
        //public ActionResult Edit(Tbl_Manager tbl_manager)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(tbl_manager).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(tbl_manager);
        //}

        //
        // GET: /Manager/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    Tbl_Manager tbl_manager = db.Tbl_Manager.Find(id);
        //    if (tbl_manager == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tbl_manager);
        //}

        //
        // POST: /Manager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Manager tbl_manager = db.Tbl_Manager.Find(id);
            db.Tbl_Manager.Remove(tbl_manager);
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