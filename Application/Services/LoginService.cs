using System;
using System.Web;
using System.Web.Security;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;
using Application.Extensions;
using Infrastructure.Services;
using Infrastructure.Extensions;
namespace Application.Services
{
    public class LoginService : IPopulateModel<Login, LoginViewModel>
    {
        public Login PopulateModel(LoginViewModel viewModel)
        {
            Login login = new Login();
            login.User = new User();
            login.User.Email = viewModel.Email;
            login.User.Password = Password.GetMD5Hash(viewModel.Password);
            return login;
        }

        public static bool UserIsLogged(HttpContextBase httpContext)
        {
            return httpContext != null &&
                   httpContext.Request != null &&
                  (User)httpContext.Session["User"] != null;
        }

        public static User GetUserLogged(HttpContextBase httpContext)
        {
            return (User)httpContext.Session["User"];
        }

        public static void Login(HttpContextBase httpContext, User user)
        {
            if (user == null)
                return;
            Logout(httpContext);
            httpContext.Session.Add("User", user);
            FormsAuthentication.SetAuthCookie("User", true);
            SaveLogin(user);
        }

        private static void SaveLogin(User user)
        {
            IGenericRepository<Login> loginRepository = new GenericRepository<Login>();
            Login login = new Login();
            login.IdUser = user.Id;
            login.DateLogin = DateTime.Now.ToBrazilianTime();
            loginRepository.Save(login);
        }

        public static void Logout(HttpContextBase httpContext)
        {
            FormsAuthentication.SignOut();
            httpContext.Response.Cookies[FormsAuthentication.FormsCookieName].Value = null;
            httpContext.Session.Clear();
        }
    }
}