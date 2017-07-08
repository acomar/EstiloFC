using System;
using System.Linq.Expressions;

namespace Application.Services
{
    public interface IPopulateModel<model, viewModel>
        where model : class
        where viewModel : class
    {
        model PopulateModel(viewModel viewModel);
    }
}