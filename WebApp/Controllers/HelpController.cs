using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HelpController : Controller
    {
        //
        // GET: /Help/

        public ActionResult Deliveries()
        {
            return View("Deliveries", "_LayoutClean");
        }
        public ActionResult Payments()
        {
            return View("Payments", "_LayoutClean");

        }
        public ActionResult Exchanges()
        {
            return View("Exchanges", "_LayoutClean");

        }
        public PartialViewResult PartialExchanges()
        {
            return PartialView("_Exchanges");

        }
        public ActionResult Cancellations()
        {
            return View("Cancellations", "_LayoutClean");

        }
        public ActionResult TableSize()
        {
            return View("TableSize", "_LayoutClean");

        }

    }
}
