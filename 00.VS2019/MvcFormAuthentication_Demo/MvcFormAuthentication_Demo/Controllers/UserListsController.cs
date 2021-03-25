using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcFormAuthentication_Demo.DataModels;

namespace MvcFormAuthentication_Demo.Controllers
{
    [Authorize]
    public class UserListsController : Controller
    {
        private awDBEntities db = new awDBEntities();

        // GET: UserLists
        public async Task<ActionResult> Index()
        {
            var userLists = db.UserLists.Include(u => u.UserRole);
            return View(await userLists.ToListAsync());
        }

        // GET: UserLists/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserList userList = await db.UserLists.FindAsync(id);
            if (userList == null)
            {
                return HttpNotFound();
            }
            return View(userList);
        }

        // GET: UserLists/Create
        public ActionResult Create()
        {
            ViewBag.RoleId = new SelectList(db.UserRoles, "Id", "Roles");
            return View();
        }

        // POST: UserLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "UserId,UserName,Email,Password,Mobile,IsActive,RoleId,LastLoginDate,LoginFailedCount,LoginIPAddress,CustomerTimeZone,LastAccessedDate,AccountLocked")] UserList userList)
        {
            if (ModelState.IsValid)
            {
                db.UserLists.Add(userList);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.RoleId = new SelectList(db.UserRoles, "Id", "Roles", userList.RoleId);
            return View(userList);
        }

        // GET: UserLists/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserList userList = await db.UserLists.FindAsync(id);
            if (userList == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoleId = new SelectList(db.UserRoles, "Id", "Roles", userList.RoleId);
            return View(userList);
        }

        // POST: UserLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "UserId,UserName,Email,Password,Mobile,IsActive,RoleId,LastLoginDate,LoginFailedCount,LoginIPAddress,CustomerTimeZone,LastAccessedDate,AccountLocked")] UserList userList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userList).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.RoleId = new SelectList(db.UserRoles, "Id", "Roles", userList.RoleId);
            return View(userList);
        }

        // GET: UserLists/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserList userList = await db.UserLists.FindAsync(id);
            if (userList == null)
            {
                return HttpNotFound();
            }
            return View(userList);
        }

        // POST: UserLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            UserList userList = await db.UserLists.FindAsync(id);
            db.UserLists.Remove(userList);
            await db.SaveChangesAsync();
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
