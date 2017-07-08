using System;
using System.Linq.Expressions;

namespace Application.Services
{
    public interface IPopulateViewModel<model, viewModel>
        where model : class
        where viewModel : class
    {
        viewModel PopulateViewModel(model model);
    }
}