using System.Web.Mvc;
using Application.Filters;
using Application.Services;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;

namespace WebApp.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IGenericRepository<ContactUs> contactUsRepository;
        private readonly IPopulateModel<ContactUs, ContactUsViewModel> contactUsService;

        public ContactUsController(IGenericRepository<ContactUs> contactUsRepository, 
                                    IPopulateModel<ContactUs, ContactUsViewModel> contactUsService)
        {
            this.contactUsRepository = contactUsRepository;
            this.contactUsService = contactUsService;
        }
       [OutputCache(Duration = int.MaxValue, VaryByParam = "none")]
        public ViewResult Index()
        {
            return View();
        }

        public EmptyResult CreateContact(ContactUsViewModel contactUsViewModel)
        {
            ContactUs contactUs = contactUsService.PopulateModel(contactUsViewModel);
            contactUsRepository.Save(contactUs);
            return new EmptyResult();
        }
    }
}
