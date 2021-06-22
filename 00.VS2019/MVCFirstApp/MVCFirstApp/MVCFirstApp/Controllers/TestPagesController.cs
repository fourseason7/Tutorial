using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class TestPagesController : Controller
    {
        // GET: TestPages
        public string Index()
        {
            return "Hello World, this is ASP.Net MVC Tutorials";
        }
    }
}