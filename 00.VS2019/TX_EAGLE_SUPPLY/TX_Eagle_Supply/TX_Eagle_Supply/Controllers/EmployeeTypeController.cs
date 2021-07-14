using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TX_Eagle_Supply.Models;

namespace TX_Eagle_Supply.Controllers
{
    public class EmployeeTypeController : Controller
    {
        private IMSDBEntities db = new IMSDBEntities();

        // GET: EmployeeType
        public ActionResult Index()
        {
            var employeeTypes = db.EmployeeTypes;
            return View(employeeTypes.ToList());
        }

        // GET: EmployeeType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeType employeeType = db.EmployeeTypes.Find(id);
            if (employeeType == null)
            {
                return HttpNotFound();
            }
            return View(employeeType);
        }

        // GET: EmployeeType/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.Employees, "Id", "FirstName");
            return View();
        }

        // POST: EmployeeType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EmployeeTypeName,EmployeeTypeDescription,ModifiedDate")] EmployeeType employeeType)
        {
            if (ModelState.IsValid)
            {
                employeeType.ModifiedDate = DateTime.Now;
                db.EmployeeTypes.Add(employeeType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.Employees, "Id", "FirstName", employeeType.Id);
            return View(employeeType);
        }

        // GET: EmployeeType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeType employeeType = db.EmployeeTypes.Find(id);
            if (employeeType == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.Employees, "Id", "FirstName", employeeType.Id);
            return View(employeeType);
        }

        // POST: EmployeeType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EmployeeTypeName,EmployeeTypeDescription,ModifiedDate")] EmployeeType employeeType)
        {
            if (ModelState.IsValid)
            {
                employeeType.ModifiedDate = DateTime.Now;
                db.Entry(employeeType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.Employees, "Id", "FirstName", employeeType.Id);
            return View(employeeType);
        }

        // GET: EmployeeType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeType employeeType = db.EmployeeTypes.Find(id);
            if (employeeType == null)
            {
                return HttpNotFound();
            }
            return View(employeeType);
        }

        // POST: EmployeeType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeType employeeType = db.EmployeeTypes.Find(id);
            db.EmployeeTypes.Remove(employeeType);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
