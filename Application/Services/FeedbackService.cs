using System;
using System.Web;
using Application.ViewModel;
using Domain.Entities;

using Infrastructure.Extensions;
namespace Application.Services
{
    public class FeedbackService : IPopulateModelContext<Feedback, FeedbackViewModel>
    {
        public Feedback PopulateModel(FeedbackViewModel viewModel, HttpContextBase httpContextBase)
        {
            Feedback feedback = new Feedback();
            feedback.Description = viewModel.Description;
            feedback.DateCreated = DateTime.Now.ToBrazilianTime();
            feedback.DateLastUpdate = DateTime.Now.ToBrazilianTime();
            feedback.Active = true;
            var userLogged = LoginService.GetUserLogged(httpContextBase);
            if(userLogged != null)
            feedback.IdUser = userLogged.Id;
            return feedback;
        }
    }
}