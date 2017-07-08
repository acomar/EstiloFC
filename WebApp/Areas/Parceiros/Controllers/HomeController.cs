using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Areas.Parceiros.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Parceiros/Home/

        public ActionResult Index()
        {
            return View("Index", "_LayoutClean");
        }

    }
}
