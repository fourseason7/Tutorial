using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _04031811_MVC.DataModels;

namespace _04031811_MVC.Controllers.Sales
{
    public class StoresController : Controller
    {
        private AdventureWorksEntities db = new AdventureWorksEntities();

        // GET: Stores
        public ActionResult Index()
        {
            var stores = db.Stores.Include(s => s.BusinessEntity).Include(s => s.SalesPerson);
            return View(stores.ToList());
        }

        // GET: Stores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Store store = db.Stores.Find(id);
            if (store == null)
            {
                return HttpNotFound();
            }
            return View(store);
        }

        // GET: Stores/Create
        public ActionResult Create()
        {
            ViewBag.BusinessEntityID = new SelectList(db.BusinessEntities, "BusinessEntityID", "BusinessEntityID");
            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "BusinessEntityID", "BusinessEntityID");
            return View();
        }

        // POST: Stores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BusinessEntityID,Name,SalesPersonID,Demographics,rowguid,ModifiedDate")] Store store)
        {
            if (ModelState.IsValid)
            {
                db.Stores.Add(store);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BusinessEntityID = new SelectList(db.BusinessEntities, "BusinessEntityID", "BusinessEntityID", store.BusinessEntityID);
            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "BusinessEntityID", "BusinessEntityID", store.SalesPersonID);
            return View(store);
        }

        // GET: Stores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Store store = db.Stores.Find(id);
            if (store == null)
            {
                return HttpNotFound();
            }
            ViewBag.BusinessEntityID = new SelectList(db.BusinessEntities, "BusinessEntityID", "BusinessEntityID", store.BusinessEntityID);
            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "BusinessEntityID", "BusinessEntityID", store.SalesPersonID);
            return View(store);
        }

        // POST: Stores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BusinessEntityID,Name,SalesPersonID,Demographics,rowguid,ModifiedDate")] Store store)
        {
            if (ModelState.IsValid)
            {
                db.Entry(store).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BusinessEntityID = new SelectList(db.BusinessEntities, "BusinessEntityID", "BusinessEntityID", store.BusinessEntityID);
            ViewBag.SalesPersonID = new SelectList(db.SalesPersons, "BusinessEntityID", "BusinessEntityID", store.SalesPersonID);
            return View(store);
        }

        // GET: Stores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Store store = db.Stores.Find(id);
            if (store == null)
            {
                return HttpNotFound();
            }
            return View(store);
        }

        // POST: Stores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Store store = db.Stores.Find(id);
            db.Stores.Remove(store);
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
