using System.Web.Mvc;

namespace WebApp.Areas.Parceiros
{
    public class ParceirosAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Parceiros";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Parceiros_default",
                "Parceiros/{controller}/{action}/{id}",
                new { Controller="Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
