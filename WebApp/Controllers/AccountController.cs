using System.Web.Mvc;
using Application.Filters;
using Application.Services;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;

namespace WebApp.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IPopulateModel<Login, LoginViewModel> populateModelLogin;
        private readonly IPopulateModel<User, UserViewModel> populateModelUser;
        private readonly IPopulateViewModel<User, UserViewModel> populateViewModelUser;
        private readonly IGetViewModel<User> getViewModelUser;
        private readonly IGenericRepository<User> userRepository;
        private readonly IGenericRepository<Phone> phoneRepository;
        
        private readonly UserService userService;

        public AccountController(IPopulateModel<Login, LoginViewModel> populateModelLogin,
                                 IPopulateModel<User, UserViewModel> populateModelUser,
                                 IPopulateViewModel<User, UserViewModel> populateViewModelUser,
                                 IGetViewModel<User> getViewModelUser,
                                 IGenericRepository<User> userRepository,
                                 IGenericRepository<Phone> phoneRepository)
        {
            this.populateModelLogin = populateModelLogin;
            this.populateModelUser = populateModelUser;
            this.populateViewModelUser = populateViewModelUser;
            this.getViewModelUser = getViewModelUser;
            this.userRepository = userRepository;
            this.phoneRepository = phoneRepository;
            this.userService = new UserService(this.userRepository, this.phoneRepository);
        }
        [OutputCache(Duration = 3600)]
        public PartialViewResult ModalLogin()
        {
            return PartialView("ModalLogin");
        }

        public ViewResult Register()
        {
            return View("Register");
        }
        public ViewResult ForgotPassword()
        {
            return View();
        }


        public ViewResult RegisterEdit()
        {
            if (!LoginService.UserIsLogged(HttpContext))
                return Register();
            User user = getViewModelUser.GetViewModel(a => a.Id == IdLoggedUser && a.Active);
            UserViewModel userViewModel = populateViewModelUser.PopulateViewModel(user);
            return View(userViewModel);
        }

        public JsonResult CreateUser(UserViewModel userViewModel)
        {
            bool success = userService.CreateUserAndLogin(HttpContext, userViewModel);
            return DefaultJsonSuccess(success);
        }

        public JsonResult EditUser(UserViewModel userViewModel)
        {
            bool success = userService.EditUser(base.IdLoggedUser, userViewModel);
            return DefaultJsonSuccess(success);
        }

        public JsonResult EditPassword(PasswordViewModel passwordViewModel)
        {
            bool success = userService.EditPassword(base.IdLoggedUser, passwordViewModel);
            return DefaultJsonSuccess(success);
        }

        public JsonResult SendForgottenPassword(string sendTo)
        {
            bool success = userService.SendForgottenPassword(sendTo);
            return DefaultJsonSuccess(success);
        }

        private JsonResult DefaultJsonSuccess(bool success)
        {
            return Json(new
            {
                success = success
            },JsonRequestBehavior.AllowGet);
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

        public RedirectToRouteResult Logout()
        {
            LoginService.Logout(HttpContext);
            return RedirectToAction("Index", "Home");
        }

        public JsonResult GetFirstNameIfIsLogged()
        {
            var user = GetLoggedUser;

            if (user != null)
            {
                LoginService.Login(HttpContext, user);
                return Json(ResultJsonLogin(true, user.FirstName));
            }
            else
                return Json(ResultJsonLogin(false, string.Empty));
        }
    }
}
