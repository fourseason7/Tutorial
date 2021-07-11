﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrintZPLSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.WCPPDetectionScript = Neodynamic.SDK.Web.WebClientPrint.CreateWcppDetectionScript(Url.Action("ProcessRequest", "WebClientPrintAPI", null, HttpContext.Request.Url.Scheme), HttpContext.Session.SessionID);

            return View();
        }

        public ActionResult PrintZPL()
        {
            return View();
        }
    }
}