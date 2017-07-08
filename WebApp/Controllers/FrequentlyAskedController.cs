using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class FrequentlyAskedController : Controller
    {
        [OutputCache(Duration = int.MaxValue, VaryByParam = "none")]
        public ActionResult Index()
        {
            return View("Index", "_LayoutClean");
  
        }
    }
}
