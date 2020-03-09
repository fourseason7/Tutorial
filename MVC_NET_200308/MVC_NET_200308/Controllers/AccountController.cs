using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using MVC_NET_200308.DataModels;
using MVC_NET_200308.ViewModels.Account;

namespace MVC_NET_200308.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginUserList model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new awEntities())
                {
                    //var obj = db.UserLists
                    //    .Where(u => u.UserName.Equals(model.UserName) && u.Password.Equals(model.Password)).FirstOrDefault();
                    var obj = db.GetUserLoginInfo(model.UserName, model.Password).FirstOrDefault();

                    //var obj = db.UserLists.FirstOrDefault();

                    if (obj == "Success")
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, false);
                        //return RedirectToAction("LoginSuccess", "Account");
                        return RedirectToAction("Index", "Home");
                    }
                    else if (obj == "User Does not Exists")
                    {
                        ViewBag.NotValidUser = obj;
                    }
                    else
                    {
                        ViewBag.Failedcount = obj;
                    }
                    //if (obj != null)
                    //{
                    //    return RedirectToAction("LoginSuccess", "Home");
                    //}
                }
                ModelState.AddModelError(string.Empty, "Invalid Username or Password!");
            }
            return View(model);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public ActionResult LoginSuccess()
        {
            return View();
        }
    }
}