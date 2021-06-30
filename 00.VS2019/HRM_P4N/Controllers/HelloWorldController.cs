using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM_P4N.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            //return View();
            return "This is my default action....";

        }
    }
}
