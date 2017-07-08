using Application.Services;
using Application.ViewModel;
using System.Web.Mvc;
using Application.Filters;
using Repository.Repositories.BaseRepository;
using Domain.Entities;
using Application.Extensions;

namespace WebApp.Controllers
{
    public class HomeController : BaseController
    {
        private readonly SideMenuService menuService;
        

        public HomeController(SideMenuService menuService)
        {
            this.menuService = menuService;
        }

        [OutputCache(Duration = 172800, VaryByParam = "NameCategory;NameRootCategory;IdProductCategory;SearchText")]
        public ViewResult Index(ProductsViewModel productsViewModel = null)
        {
            return View("Index", "_LayoutHome", productsViewModel);
        }

        [OutputCache(Duration = int.MaxValue, VaryByParam = "none")]
        public PartialViewResult ShowModalFeedback()
        {
            return PartialView("_ModalFeedback");
        }


        [OutputCache(Duration = int.MaxValue, VaryByParam = "none")]
        public PartialViewResult SideBar()
        {
            SideMenuViewModel sideMenuViewModel = menuService.GetViewModel();
            return PartialView("_SideBar",sideMenuViewModel);
        }
    }
}