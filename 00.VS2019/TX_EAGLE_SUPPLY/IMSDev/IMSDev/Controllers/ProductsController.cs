using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IMSDev.Models;

namespace IMSDev.Controllers
{
    public class ProductsController : Controller
    {
        private IMSDBContext db = new IMSDBContext();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.ProductCategory);
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            List<ProductCategory> productCategories = new List<ProductCategory>();
            productCategories = db.ProductCategories.ToList();
            productCategories.Insert(0, new ProductCategory { Id = 0, Name = "Select" });
            ViewBag.ProductCategoryId = new SelectList(productCategories, "Id", "Name");

            List<ProductSubCategory> productSubCategories = new List<ProductSubCategory>();
            productSubCategories = db.ProductSubCategories.ToList();
            productSubCategories.Insert(0, new ProductSubCategory { Id = 0, Name = "Select" });
            ViewBag.ProductSubCategoryId = new SelectList(productSubCategories, "Id", "Name");
            //ViewBag.ProductCategoryId = new SelectList(db.ProductCategories, "Id", "Name");
            //ViewBag.ProductSubCategoryId = new SelectList(db.ProductSubCategories, "Id", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.CreatedDate = DateTime.Now;
                product.ModifiedDate = DateTime.Now;
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductCategoryId = new SelectList(db.ProductCategories, "Id", "Name", product.ProductCategoryId);
            return View(product);
        }
        //public ActionResult Create([Bind(Include = "Id,Name,Description,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,ProductCategoryId,CreatedDate,ModifiedDate")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        product.CreatedDate = DateTime.Now;
        //        product.ModifiedDate = DateTime.Now;
        //        db.Products.Add(product);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.ProductCategoryId = new SelectList(db.ProductCategories, "Id", "Name", product.ProductCategoryId);
        //    return View(product);
        //}
        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductCategoryId = new SelectList(db.ProductCategories, "Id", "Name", product.ProductCategoryId);
            ViewBag.ProductSubCategoryId = new SelectList(db.ProductSubCategories, "Id", "Name", product.ProductSubCategoryId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,ProductCategoryId,CreatedDate,ModifiedDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.ModifiedDate = DateTime.Now;
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductCategoryId = new SelectList(db.ProductCategories, "Id", "Name", product.ProductCategoryId);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult GetSubCategory(int CategoryId)
        {
            //List<ProductSubCategory> productSubCategories = new List<ProductSubCategory>();
            //productSubCategories = db.ProductSubCategories.Where(x => x.ProductCategoryId == CategoryId).ToList();
            //productSubCategories.Insert(0, new ProductSubCategory { Id = 0, Name = "Select" });
            ////ViewBag.ProductSubCategoryId = new SelectList(productSubCategories, "Id", "Name");
            
            var productSubCategories = db.ProductSubCategories.Where(s => s.ProductCategoryId == CategoryId).Select(c => new { Id = c.Id, Name = c.Name }).ToList();

            return Json(new SelectList(productSubCategories, "Id", "Name"));
            //return Json(productSubCategories);
        }

        public JsonResult GetProducts(int SubCategoryId)
        {
            List<Product> products = new List<Product>();

            products = db.Products.Where(x => x.ProductSubCategoryId == SubCategoryId).ToList();

            return Json(new SelectList(products, "Id", "Name"));
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
