using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionFiltersDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration = 5)]
        public string Index()
        {
            return string.Format("This is ASP .Net MVC Filters Tutorial - {0}", DateTime.Now.ToString("T"));
        }

        [OutputCache(Duration = 10)]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
    }
}