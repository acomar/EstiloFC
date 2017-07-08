using Application.Filters;
using Application.Services;
using Domain.Entities;
using Repository.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class OrderController : BaseController
    {
        private readonly OrderService orderService;
        public OrderController( OrderService orderService)
        {
            this.orderService = orderService;
        }
        
        [AccessAuthorize]
        public ActionResult ViewOrders()
        {
            var orders = orderService.GetOrders(this.IdLoggedUser);
            
            return View(orders);
        }
        [AccessAuthorize]
        public ActionResult Done()
        {
            var orders = orderService.GetOrders(this.IdLoggedUser);

            return View(orders);
        }
        public void Notification(string notificationCode)
        {
            orderService.Notification(notificationCode);
        }

    }
}
