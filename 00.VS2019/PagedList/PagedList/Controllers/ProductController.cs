using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using MVCPagedList.Models;
using PagedList;

namespace MVCPagedList.Controllers
{
    public class ProductController : Controller
    {
        private AdventureWorksEntities _context;
        public ProductController()
        {
            _context = new AdventureWorksEntities();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Product
        public ActionResult Index(int? Page)
        {
            // int? Page : 리스트 페이지가 불러올때 null 을 허용하는 int Page 를 받아온다.
            // Page 는 현재 호출되는 페이지 번호가 저장되어있다.
            var product = _context.Products.ToList();
            // 현재 페이지 정보가 없다면 1페이지로 간주하고 아니면 페이지 정보를 넘긴다다.
            int PageNo = Page ?? 1;

            // PageSize : 한 페이지에 불러올 컨텐츠의 수
            int PageSize = 3;

            return View(product.ToPagedList(PageNo, PageSize));
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.ProductID == id);
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.ProductID == id);

            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var product = _context.Products.Single(u => u.ProductID == id);
                    if (TryUpdateModel(product))
                    {
                        _context.SaveChanges();
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            Product product = _context.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Product product = _context.Products.Find(id);
            try
            {
                // TODO: Add delete logic here
                _context.Products.Remove(product);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                
                return View(product);
            }
        }
    }
}
