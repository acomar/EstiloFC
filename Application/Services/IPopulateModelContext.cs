using System.Web;

namespace Application.Services
{
    public interface IPopulateModelContext<model, viewModel>
        where model : class
        where viewModel : class
    {
        model PopulateModel(viewModel viewModel, HttpContextBase httpContextBase);
    }
}