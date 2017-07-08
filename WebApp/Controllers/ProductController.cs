using System.Web.Mvc;
using Application.Services;
using Application.ViewModel;
using Domain.Entities;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGetViewModel<Stock> stockService;

        public ProductController(IGetViewModel<Stock> stockGet)
        {
            this.stockService = stockGet;
        }

        public PartialViewResult GetByFilters(ProductsViewModel filters = null)
        {
            var productsViewModel = stockService.GetViewModel(filters);
            return PartialView("_produtcts", productsViewModel);
        }

        //[OutputCache(Duration = int.MaxValue, VaryByParam = "id")]
        public ViewResult Detail(int id)
        {
            var viewModel = stockService.GetViewModel(c => c.Product.Id == id);

            return View("Detail", "_LayoutClean", viewModel);
        }
    }
}
