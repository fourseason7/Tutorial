using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MvcFormAuthentication_Demo.DataModels;
using MvcFormAuthentication_Demo.ViewModels;

namespace MvcFormAuthentication_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly awDBEntities _dbcontext = new awDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginUser model)
        {
            if (ModelState.IsValid)
            {
                //bool IsValidUser = _dbcontext.UserLists
                //    .Any(u => u.UserName.Equals(model.UserName) && u.Password.Equals(model.Password) && (u.IsActive == true || u.AccountLocked == true));

                var user = _dbcontext.GetUserLoginInfo(model.UserName, model.Password).FirstOrDefault();

                if (user == "Success")
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Home");
                }
                else if (user == "User Does not Exists")

                {
                    ViewBag.NotValidUser = user;

                }
                else
                {
                    ViewBag.Failedcount = user;
                }

                //var user = _dbcontext.UserLists.Where(u => u.UserName.Equals(model.UserName) && u.Password.Equals(model.Password)).FirstOrDefault();

                //if (user != null )
                //{
                //    if (user.AccountLocked == true)
                //    {
                //        ModelState.AddModelError("", "Account is locked! Please, contact to admin!");
                //        return View();
                //    }

                //    if (user.IsActive == true)
                //    {
                //        ModelState.AddModelError("", string.Format("{0} is inactive account. Please, contact to admin", user.UserName));
                //        return View();
                //    }
                //    FormsAuthentication.SetAuthCookie(model.UserName, false);
                //    return RedirectToAction("Index", "Home");
                //}

                //if (IsValidUser)
                //{
                //    FormsAuthentication.SetAuthCookie(model.UserName, false);
                //    return RedirectToAction("Index", "Home");
                //}
            }
            ModelState.AddModelError("", "Invalid User Name or Password");
            return View(model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}