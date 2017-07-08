using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class InstitutionalController : Controller
    {
        [OutputCache(Duration = int.MaxValue, VaryByParam = "none")]
        public ActionResult About()
        {
            return View("About", "_LayoutClean");
        }

        [OutputCache(Duration = int.MaxValue, VaryByParam = "none")]
        public ActionResult PrivacyPolicy()
        {
            return View("PrivacyPolicy", "_LayoutClean");
        }

        [OutputCache(Duration = int.MaxValue, VaryByParam = "none")]
        public ActionResult TermsOfUse()
        {
            return View("TermsOfUse", "_LayoutClean");
        }
    }
}
