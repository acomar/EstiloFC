using System;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;
using System.Linq;
using Application.Extensions;

namespace Application.Services
{
    public class ContactService : IPopulateModel<Contact, ContactViewModel>
    {
        private readonly IGenericRepository<Contact> contactRepository;

        public ContactService(IGenericRepository<Contact> contactRepository)
        {
            this.contactRepository = contactRepository; 
        }

        public Contact PopulateModel(ContactViewModel viewModel)
        {
            Contact contact = contactRepository.Find(viewModel.IdContact);
            if (contact == null)
                contact = new Contact();
            contact.ContactDescription = viewModel.ContactNumber;
            return contact;
        }

        public int Save(Contact contact)
        {
            return contactRepository.Save(contact);
        }

        public void Edit(Contact contact)
        {
            contactRepository.Edit(contact);
        }
    }
}