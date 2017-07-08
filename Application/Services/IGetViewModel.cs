using System;
using System.Linq.Expressions;
using Application.ViewModel;

namespace Application.Services
{
    public interface IGetViewModel<T> where T : class
    {
        dynamic GetViewModel();
        dynamic GetViewModel(Expression<Func<T, bool>> predicate);
        dynamic GetViewModel(PaginationViewModel predicate);
    }
}