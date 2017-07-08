using System.Web.Mvc;
using Application.Services;

namespace Application.Filters
{
    public class AccessAuthorize : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(System.Web.HttpContextBase httpContext)
        {
            bool result = false;
            if (LoginService.UserIsLogged(httpContext))
                result = true;
            return result;
            
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new EmptyResult();
            filterContext.HttpContext.Response.StatusCode = 401; 
        }
    }
}
