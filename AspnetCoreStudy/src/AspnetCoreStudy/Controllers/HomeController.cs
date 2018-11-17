using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCoreStudy.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCoreStudy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var firstUser = new User();

            var hongUser = new User
            {
                UserNo = 1,
                UserName = "Hong, Gildong"
            };

            // first way
            //return View(hongUser);

            // second way
            //ViewBag.User = hongUser;

            // Thired way
            ViewData["UserNo"] = hongUser.UserNo;
            ViewData["UserName"] = hongUser.UserName;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
