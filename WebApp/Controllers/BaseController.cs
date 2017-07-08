using Domain.Entities;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public abstract class BaseController : Controller
    {
        protected int IdLoggedUser { 
            get {
                User user = this.GetLoggedUser;
                return (user != null) ? user.Id : 0;
            } 
        }

        protected User GetLoggedUser
        {
            get
            {
                return  (User)HttpContext.Session["User"];
            }
        }
        protected string GetFirstName
        {
            get
            {
                return ((User)HttpContext.Session["User"]).FirstName;
            }
        }

        public JsonResult IsLogged()
        {
            return Json(new { 
                success = (GetLoggedUser != null)
            });                 
        }
    }
}
