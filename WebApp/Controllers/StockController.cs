using Application.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class StockController : Controller
    {

        private readonly StockService stockService;

        public StockController(StockService stockService)
        {
            this.stockService = stockService;
        }
        public ActionResult GetSizesAndColors(int idProduct, int? idColor = null, int? idSize = null)
        {
            var colors = stockService.GetColors(idProduct, idColor, idSize);
            var sizes = stockService.GetSizes(idProduct, idColor, idSize);
            return this.Json(new { Sizes = sizes, Colors = colors }, JsonRequestBehavior.AllowGet);
        }

    }
}
