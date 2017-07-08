using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Enums;

namespace Application.Services
{
    public class CollectionService 
    {
        private readonly IGenericRepository<Product> productRepository;
        private readonly IGenericRepository<OrderItem> orderItemRepository;

        public CollectionService(IGenericRepository<Product> productRepository, IGenericRepository<Basket> basket, IGenericRepository<Size> size, IGenericRepository<Stock> stock, IGenericRepository<StockHistory> stockHistoryRepository, IGenericRepository<OrderItem> orderItemRepository)
        {
            this.productRepository = productRepository;
            this.orderItemRepository = orderItemRepository;
        }

        public dynamic GetColection(User user)
        {
            var collection = new List<CollectionViewModel>();
            List<OrderItem> myProducts = null;
            if(user != null )
                myProducts = orderItemRepository.FindAllBy(c => c.Order.User.Id == user.Id && c.Order.OrderStatus.Id == (int)OrderStatusEnum.PAGA).ToList();
            var products = productRepository.FindAllBy(c => c.Active).Include(p => p.Price).ToList();
            foreach (var item in products)
            {
                var collectionItem = new CollectionViewModel(item);
                if(myProducts != null)
                collectionItem.IHave = myProducts.Where(c => c.Product.Id == item.Id).Any();
                collection.Add(collectionItem);
            }
            return collection;
        }
    }
}