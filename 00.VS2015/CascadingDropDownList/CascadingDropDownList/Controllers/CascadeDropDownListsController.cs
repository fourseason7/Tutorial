using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CascadingDropDownList.Models;

namespace CascadingDropDownList.Controllers
{
    public class CascadeDropDownListsController : Controller
    {
        private SampleDBEntities db = new SampleDBEntities();

        // GET: CascadeDropDownLists
        public ActionResult Index()
        {
            ViewBag.categories = db.categories.ToList();
            var subcategories = db.subcategories.Include(s => s.category);
            return View(subcategories.ToList());
        }

        private IList<subcategory> Getsubcategories(int categoryId)
        {
            return db.subcategories.Where(x => x.CatId == categoryId).ToList();
        }

        public JsonResult LoadSubCategoryId(int categoryId)
        {
            var subcategoriesList = Getsubcategories(categoryId);
            var subcategoriesData = subcategoriesList.Select(m => new SelectListItem()
            {
                Text = m.Subcategoryname.ToString(),
                Value = m.subcatId.ToString(),
            });
            return Json(subcategoriesData, JsonRequestBehavior.AllowGet);
        }
        // GET: CascadeDropDownLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subcategory subcategory = db.subcategories.Find(id);
            if (subcategory == null)
            {
                return HttpNotFound();
            }
            return View(subcategory);
        }

        // GET: CascadeDropDownLists/Create
        public ActionResult Create()
        {
            ViewBag.CatId = new SelectList(db.categories, "categoryId", "categoryName");
            return View();
        }

        // POST: CascadeDropDownLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "subcatId,CatId,Subcategoryname")] subcategory subcategory)
        {
            if (ModelState.IsValid)
            {
                db.subcategories.Add(subcategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CatId = new SelectList(db.categories, "categoryId", "categoryName", subcategory.CatId);
            return View(subcategory);
        }

        // GET: CascadeDropDownLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subcategory subcategory = db.subcategories.Find(id);
            if (subcategory == null)
            {
                return HttpNotFound();
            }
            ViewBag.CatId = new SelectList(db.categories, "categoryId", "categoryName", subcategory.CatId);
            return View(subcategory);
        }

        // POST: CascadeDropDownLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "subcatId,CatId,Subcategoryname")] subcategory subcategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subcategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CatId = new SelectList(db.categories, "categoryId", "categoryName", subcategory.CatId);
            return View(subcategory);
        }

        // GET: CascadeDropDownLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            subcategory subcategory = db.subcategories.Find(id);
            if (subcategory == null)
            {
                return HttpNotFound();
            }
            return View(subcategory);
        }

        // POST: CascadeDropDownLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            subcategory subcategory = db.subcategories.Find(id);
            db.subcategories.Remove(subcategory);
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
