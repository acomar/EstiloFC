using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;
using Application.Extensions;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Application.Services
{
    public class StockService : IGetViewModel<Stock>
    {
        private readonly IGenericRepository<Product> products;
        private readonly IGenericRepository<Basket> basketProducts;
        private readonly IGenericRepository<Size> sizeRepository;
        private readonly IGenericRepository<Stock> stockRepository;
        private readonly IGenericRepository<StockHistory> stockHistoryRepository;
        private readonly IGenericRepository<OrderItem> orderItemRepository;

        public StockService(IGenericRepository<Product> products, IGenericRepository<Basket> basket, IGenericRepository<Size> size, IGenericRepository<Stock> stock, IGenericRepository<StockHistory> stockHistoryRepository, IGenericRepository<OrderItem> orderItemRepository)
        {
            this.sizeRepository = size;
            this.products = products;
            this.basketProducts = basket;
            this.stockRepository = stock;
            this.stockHistoryRepository = stockHistoryRepository;
            this.orderItemRepository = orderItemRepository;
            
        }

        public dynamic GetViewModel()
        {
            var productsViewModel = new ProductsViewModel();
            productsViewModel.NextAction = "GetByFilters";
            return GetViewModel(productsViewModel);
        }

        public dynamic GetViewModel(Expression<Func<Stock, bool>> predicate)
        {
            var productsViewModel = new ProductsViewModel();
            productsViewModel.Products = stockRepository.FindAllBy(predicate).Include(p => p.Product.ManufacturingData).Include(p => p.Product.Price).ToList().Select(p => p.Product).ToList();
            productsViewModel.Products = productsViewModel.Products.Distinct().ToList();
            return productsViewModel;
        }

        public dynamic GetViewModel(PaginationViewModel pagination)
        {
            var viewModel = (ProductsViewModel)pagination;
            var searchIsNull = string.IsNullOrEmpty(viewModel.SearchText);
            var nameCategoryIsNull = string.IsNullOrEmpty(viewModel.NameCategory);
            if (!nameCategoryIsNull)
                viewModel.NameCategory = viewModel.NameCategory;
            var nameRootCategoryIsNull = string.IsNullOrEmpty(viewModel.NameRootCategory);
            var query = stockRepository.FindAllBy(p => p.Product.Active && p.Quantity > 0 &&
                (viewModel.IdProductCategory.Equals(0) || p.Product.IdProductCategory == viewModel.IdProductCategory) &&
                (searchIsNull || p.Product.Description.Contains(viewModel.SearchText) || p.Product.Name.Contains(viewModel.SearchText)) &&
                (nameRootCategoryIsNull || p.Product.ProductCategory.RootCategory.Name == viewModel.NameRootCategory)).Select(p => p.Product);
            viewModel.Products = query.Distinct().OrderByDescending(p => p.Relevance).Skip(viewModel.Skip).Take(viewModel.NumberPerPage).ToList();
            viewModel.Products = viewModel.Products.Where(p => (nameCategoryIsNull || p.ProductCategory.NameForRoute == viewModel.NameCategory)).ToList();
            viewModel.Skip += viewModel.NumberPerPage;
            return viewModel;
        }


        public void IncrementRelevance(int id)
        {
            var product = products.Find(id);
            product.Relevance++;
            products.Edit(product);
        }

        public List<Color> GetColors(int idProduct, int? idColor, int? idSize)
        {
            return stockRepository.FindAllBy(c => c.Product.Id == idProduct
                && c.Quantity > 0
                && (!idColor.HasValue || c.Color.Id == idColor)
                && (!idSize.HasValue || c.Size.Id == idSize)
                ).Include(s => s.Color).ToList().Select(p => p.Color).Distinct().ToList();
        }
        public List<Size> GetSizes(int idProduct, int? idColor, int? idSize)
        {
            return stockRepository.FindAllBy(c => c.Product.Id == idProduct
                && c.Quantity > 0
                && (!idColor.HasValue || c.Color.Id == idColor)
                && (!idSize.HasValue || c.Size.Id == idSize)
                ).Include(s => s.Size).ToList().Select(p => p.Size).Distinct().ToList();
        }

        public Stock GetStock(int idProduct, int idColor, int idSize)
        {
            return stockRepository.FindFirstBy(c => c.Product.Id == idProduct
                                       && c.Color.Id == idColor
                                       && c.Size.Id == idSize);
        }

        public void Add(Stock stock, int quantity)
        {
            if (stock != null)
            {
                stock.Quantity += quantity;
                stockRepository.Edit(stock);
                stockHistoryRepository.Save(new StockHistory(stock));
            }
        }

        public bool Remove(Stock stock, int quantity = 1)
        {
            if (stock != null && stock.InStock(quantity))
            {
                stock.Quantity -= quantity;
                stockRepository.Edit(stock);
                stockHistoryRepository.Save(new StockHistory(stock));
                return true;
            }
            return false;
        }

        public bool CheckStock(Order order)
        {
            GetOrdemItens(order);
            foreach (var item in order.OrderItens)
            {
               var stock = GetStock(item.IdProduct, item.IdColor, item.IdSize);
               if (!stock.InStock(item.Quantity))
                   return false;
            }
            return true;
        }

        private void GetOrdemItens(Order order)
        {
            if (order.OrderItens == null)
                order.OrderItens = orderItemRepository.FindAllBy(c => c.IdOrder == order.Id).ToList();

        }

        public void Remove(Order order)
        {
            GetOrdemItens(order);
            foreach (var item in order.OrderItens)
            {
                var stock = GetStock(item.IdProduct, item.IdColor, item.IdSize);
                Remove(stock, item.Quantity);
            }
        }

        internal void Add(Order order)
        {
            GetOrdemItens(order); 
            foreach (var item in order.OrderItens)
            {
                var stock = GetStock(item.IdProduct, item.IdColor, item.IdSize);
                Add(stock, item.Quantity);
            }
        }
    }
}