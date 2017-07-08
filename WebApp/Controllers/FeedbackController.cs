using System.Web.Mvc;
using Application.Filters;
using Application.Services;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;

namespace WebApp.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IGenericRepository<Feedback> feedbackRepository;
        private readonly IPopulateModelContext<Feedback, FeedbackViewModel> feedbackService;

        
        public FeedbackController(IGenericRepository<Feedback> feedbackRepository, 
                                    IPopulateModelContext<Feedback, FeedbackViewModel> feedbackService)
        {
            this.feedbackRepository = feedbackRepository;
            this.feedbackService = feedbackService;
        }

       
        public EmptyResult CreateFeedback(FeedbackViewModel feedbackViewModel)
        {
            Feedback feedback = feedbackService.PopulateModel(feedbackViewModel, HttpContext);
            feedbackRepository.Save(feedback);
            return new EmptyResult();
        }
    }
}
