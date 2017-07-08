using System;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;
using System.Linq;
using Application.Extensions;

namespace Application.Services
{
    public class AddressService : IPopulateModel<Address, AddressViewModel>
    {
        private readonly IGenericRepository<Address> addressRepository;

        public AddressService(IGenericRepository<Address> addressRepository)
        {
            this.addressRepository = addressRepository; 
        }

        public Address PopulateModel(AddressViewModel viewModel)
        {
            Address address = addressRepository.FindFirstBy(x => x.IdUser == viewModel.IdUser);
            if (address == null)
                address = new Address();
            address.ZipCode = viewModel.ZipCode;
            address.IdCity = viewModel.IdCity;
            address.Street = viewModel.Address;
            address.Number = viewModel.Number;
            address.Neighbornhood = viewModel.Neighborhood;
            address.Complement = viewModel.Complement;
            address.IdUser = viewModel.IdUser;
            return address;
        }

        public int SaveOrEditAddress(AddressViewModel addressViewModel, int idLoggedUser)
        {
            addressViewModel.IdUser = idLoggedUser;
            Address address = this.PopulateModel(addressViewModel);
            if (address.Id == 0)
                address.Id = addressRepository.Save(address);
            else
                addressRepository.Edit(address);
            return address.Id;
        }
    }
}