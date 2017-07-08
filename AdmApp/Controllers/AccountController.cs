using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using AdmApp.Models;
using Application.Services;
using Domain.Entities;
using Repository.Repositories.BaseRepository;

namespace AdmApp.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly IPopulateModel<Login, LoginViewModel> populateModelLogin;
        private readonly IGenericRepository<User> userRepository;
        private readonly IGenericRepository<Phone> phoneRepository;

        private readonly UserService userService;

        public AccountController(IPopulateModel<Login, LoginViewModel> populateModelLogin,
                                 IGenericRepository<User> userRepository,
                                 IGenericRepository<Phone> phoneRepository)
        {
            this.populateModelLogin = populateModelLogin;
            this.userRepository = userRepository;
            this.userService = new UserService(this.userRepository, this.phoneRepository);
        }

        [HttpPost]
        public JsonResult Login(LoginViewModel loginViewModel)
        {
            Login login = populateModelLogin.PopulateModel(loginViewModel);
            User user = userRepository.FindFirstBy(u => u.Email.Equals(login.User.Email));
            return LoginUser(login, user);
        }

        private JsonResult LoginUser(Login login, User user)
        {
            if (login.LoginUser(user))
            {
                LoginService.Login(HttpContext, user);
                return Json(ResultJsonLogin(true, user.FirstName));
            }
            else
                return Json(ResultJsonLogin(false, string.Empty));
        }

        private object ResultJsonLogin(bool success, string firstName)
        {
            return new
            {
                success = success,
                firstName = firstName
            };
        }
       
    }
}