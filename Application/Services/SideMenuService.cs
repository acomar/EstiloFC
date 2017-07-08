using System;
using System.Linq;
using System.Linq.Expressions;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;


namespace Application.Services
{
    public class SideMenuService : IGetViewModel<ProductCategory>
    {
        private readonly IGenericRepository<ProductCategory> productCategoryRepository;

        public SideMenuService(IGenericRepository<ProductCategory> productCategoryRepository)
        {
            this.productCategoryRepository = productCategoryRepository;
        }

        public dynamic GetViewModel()
        {
            var sideMenuViewModel = new SideMenuViewModel();
            sideMenuViewModel.Menu = productCategoryRepository.FindAllBy(productCategory =>
                                                                         productCategory.Active &&
                                                                        !productCategory.IdRootCategory.HasValue);
            FilterActiveChields(sideMenuViewModel);
            return sideMenuViewModel;
        }

        private void FilterActiveChields(SideMenuViewModel sideMenuViewModel)
        {
            sideMenuViewModel.Menu.ToList().ForEach(pc =>
            {
                if (pc.ProductCategoryChields != null)                
                    pc.ProductCategoryChields = pc.ProductCategoryChields.Where(c => c.Active).ToList();                
            });
        }

        public dynamic GetViewModel(Expression<Func<ProductCategory, bool>> predicate)
        {
            return null;
        }

      
        public dynamic GetViewModel(PaginationViewModel predicate)
        {
            throw new NotImplementedException();
        }
    }
}