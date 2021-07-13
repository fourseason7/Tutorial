using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompShop.Controllers
{
    public class ItemController : Controller
    {
        //GET: Item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";
            return View();
        }

    }
}