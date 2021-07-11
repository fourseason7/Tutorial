using Neodynamic.SDK.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrintZPLSample.Controllers
{
    public class PrintZPLController : Controller
    {
		public ActionResult Index()
		{
			ViewBag.WCPScript = WebClientPrint.CreateScript(Url.Action("ProcessRequest", "WebClientPrintAPI", null, HttpContext.Request.Url.Scheme), Url.Action("PrintCommands", "PrintZPL", null, HttpContext.Request.Url.Scheme), HttpContext.Session.SessionID);

			return View();
		}

		[AllowAnonymous]
		public void PrintCommands(string useDefaultPrinter, string printerName)
		{
			//Create Zebra ZPL commands for sample receipt
			string cmds = "^XA";
			cmds += "^FO20,30^GB750,1100,4^FS";
			cmds += "^FO20,30^GB750,200,4^FS";
			cmds += "^FO20,30^GB750,400,4^FS";
			cmds += "^FO20,30^GB750,700,4^FS";
			cmds += "^FO20,226^GB325,204,4^FS";
			cmds += "^FO30,40^ADN,36,20^FDShip to:^FS";
			cmds += "^FO30,260^ADN,18,10^FDPart number #^FS";
			cmds += "^FO360,260^ADN,18,10^FDDescription:^FS";
			cmds += "^FO30,750^ADN,36,20^FDFrom:^FS";
			cmds += "^FO150,125^ADN,36,20^FDAcme Printing^FS";
			cmds += "^FO60,330^ADN,36,20^FD14042^FS";
			cmds += "^FO400,330^ADN,36,20^FDScrew^FS";
			cmds += "^FO70,480^BY4^B3N,,200^FD12345678^FS";
			cmds += "^FO150,800^ADN,36,20^FDMacks Fabricating^FS";
			cmds += "^XZ";

			//Create a ClientPrintJob and send it back to the client!
			ClientPrintJob cpj = new ClientPrintJob();
			//set Zebra ZPL commands to print...
			cpj.PrinterCommands = cmds;
			cpj.FormatHexValues = true;

			//set client printer...
			if (useDefaultPrinter == "checked" || printerName == "null")
				cpj.ClientPrinter = new DefaultPrinter();
			else
				cpj.ClientPrinter = new InstalledPrinter(printerName);

			//send it...
			System.Web.HttpContext.Current.Response.ContentType = "application/octet-stream";
			System.Web.HttpContext.Current.Response.BinaryWrite(cpj.GetContent());
			System.Web.HttpContext.Current.Response.End();

		}
	}
}