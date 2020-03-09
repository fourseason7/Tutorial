using MVC_Login.DataModels;
using MVC_Login.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Login.Controllers
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
        public ActionResult Login(LoginUser model)
        {
            if (ModelState.IsValid)
            {
                using (awEntities db = new awEntities())
                {
                    //var user = db.UserLists.Where(u => u.UserName.Equals(model.UserName) && u.Password.Equals(model.Password)).FirstOrDefault();
                    var user = db.GetUserLoginInfo(model.UserName, model.Password).FirstOrDefault();

                    if (user == "Success")
                    {
                        //return RedirectToAction("LoginSuccess", "Account");
                        Session["UserName"] = model.UserName;
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
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {

            Session.Abandon();
            return RedirectToAction("Login", "Account");
        }
    }
}