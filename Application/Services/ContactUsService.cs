using System;
using Application.ViewModel;
using Domain.Entities;
using Infrastructure.Extensions;

namespace Application.Services
{
    public class ContactUsService : IPopulateModel<ContactUs, ContactUsViewModel>
    {
        public ContactUs PopulateModel(ContactUsViewModel viewModel)
        {
            ContactUs contactUs = new ContactUs();
            contactUs.Name = viewModel.Name;
            contactUs.Email = viewModel.Email;
            contactUs.Message = viewModel.Message;
            contactUs.DateCreated = DateTime.Now.ToBrazilianTime();
            contactUs.DateLastUpdate = DateTime.Now.ToBrazilianTime();
            contactUs.Active = true; 
            return contactUs;
        }
    }
}