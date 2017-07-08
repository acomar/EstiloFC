using Application.Services;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class CollectionController : BaseController
    {
 
        private readonly CollectionService collectionService;
        public CollectionController(CollectionService collectionService)
        {
            this.collectionService = collectionService;
        }

        public ActionResult Index()
        {
            var user = GetLoggedUser;
            List<CollectionViewModel> model = collectionService.GetColection(user);
            return View("Index", "_LayoutClean", model);
        }

    }
}
