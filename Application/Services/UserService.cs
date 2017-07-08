using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using System.Web.Security;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;
using System.Linq;
using Infrastructure.Services;
using Application.Extensions;
using Infrastructure.Extensions;
namespace Application.Services
{
    public class UserService : IPopulateModel<User, UserViewModel>, IPopulateViewModel<User, UserViewModel>, IGetViewModel<User>
    {
        private readonly IGenericRepository<User> userRepository;
        private readonly IGenericRepository<Phone> phoneRepository;
        public UserService(IGenericRepository<User> userRepository, IGenericRepository<Phone> phoneRepository)
        {
            this.userRepository = userRepository;
            this.phoneRepository = phoneRepository;

        }

        public User PopulateModel(UserViewModel viewModel)
        {
            User user = new User();
            user.FirstName = viewModel.FirstName;
            user.LastName = viewModel.LastName;
            user.AreaCode = viewModel.AreaCode;
            user.Number = viewModel.Number;
            user.Birthday = viewModel.Birthday;
            user.IdGender = viewModel.Gender.Id;
            user.Email = viewModel.Email;
            user.Password = Password.GetMD5Hash(viewModel.Password);
            user.Cpf = viewModel.Cpf;
            user.Active = true;
            user.DateCreated = DateTime.Now.ToBrazilianTime();
            user.DateLastUpdate = DateTime.Now.ToBrazilianTime();
            return user;
        }

        public UserViewModel PopulateViewModel(User model)
        {
            UserViewModel userViewModel = new UserViewModel();
            userViewModel.FirstName = model.FirstName;
            userViewModel.LastName = model.LastName;
            userViewModel.AreaCode = model.AreaCode;
            userViewModel.Number = model.Number;
            userViewModel.Birthday = model.Birthday;
            userViewModel.Gender = model.Gender;
            userViewModel.Email = model.Email;
            userViewModel.Password = model.Password;
            userViewModel.Cpf = model.Cpf;
            return userViewModel;
        }

        public bool CreateUserAndLogin(HttpContextBase httpContext, UserViewModel userViewModel)
        {
            if (this.ExistEmail(userViewModel.Email))
                return false;
            User user = this.PopulateModel(userViewModel);
            user.Id = userRepository.Save(user);
            user.SendEmailSuccessRegister(user.Email);
            LoginService.Login(httpContext, user);
            return true;
        }

        public bool EditUserContact(int idLoggedUser, int idContact)
        {
            User user = userRepository.Find(idLoggedUser);
            user.IdContact = idContact;
            user.DateLastUpdate = DateTime.Now.ToBrazilianTime();
            userRepository.Edit(user);
            return true;
        }

        public bool EditUser(int idUserLogged, UserViewModel userViewModel)
        {
            User user = userRepository.Find(idUserLogged);
            user.FirstName = userViewModel.FirstName;
            user.LastName = userViewModel.LastName;
            user.Cpf = userViewModel.Cpf;
            user.Birthday = userViewModel.Birthday;
            user.AreaCode = userViewModel.AreaCode;
            user.Number = userViewModel.Number;
            user.DateLastUpdate = DateTime.Now.ToBrazilianTime();
            userRepository.Edit(user);
            return true;
        }

        public bool EditPassword(int idUserLogged, PasswordViewModel passwordViewModel)
        {
            User user = userRepository.Find(idUserLogged);
            if (!user.ConfirmPassword(Password.GetMD5Hash(passwordViewModel.CurrentPassword)))
                return false;
            EditPassword(passwordViewModel.NewPassword, user);
            return true;
        }

        private void EditPassword(string newPassword, User user)
        {
            newPassword = Password.GetMD5Hash(newPassword);
            user.EditPassword(newPassword);
            user.DateLastUpdate = DateTime.Now.ToBrazilianTime();
            userRepository.Edit(user);
        }

        private bool ExistEmail(string email)
        {
            return userRepository.FindFirstBy(u => u.Email.Equals(email)) != null;
        }

        public bool SendForgottenPassword(string sendTo)
        {
            User user = userRepository.FindFirstBy(u => u.Email == sendTo);
            if (user == null)
                return false;
            var password = Password.GetRandomPassword();
            EditPassword(password, user);
            user.SendEmailForgottenPassword(user.Email, password);
            return true;
        }

        public dynamic GetViewModel()
        {
            var users = new List<User>();
            users = userRepository.GetAll().ToList();
            return users;
        }

        public dynamic GetViewModel(System.Linq.Expressions.Expression<System.Func<User, bool>> predicate)
        {
            var user = new User();
            user = userRepository.FindFirstBy(predicate);
            return user;
        }

        public dynamic GetViewModel(PaginationViewModel predicate)
        {
            throw new NotImplementedException();
        }
    }
}