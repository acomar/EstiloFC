using System;
using System.Web.Mvc;
using Application.Services;
using Domain.Entities;

namespace Application.Filters
{
    public class ActionLog : ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;
            string ipRequest = filterContext.HttpContext.Request.UserHostAddress;
            DateTime dateRequest = filterContext.HttpContext.Timestamp;
            User user = LoginService.GetUserLogged(filterContext.HttpContext);
            int? idLoggedUser = user == null ? null : (int?)user.Id; 
            this.OnActionExecuting(filterContext);
        }
    }
}
