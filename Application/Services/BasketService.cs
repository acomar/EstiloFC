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
using Infrastructure.Extensions;

namespace Application.Services
{
    public class BasketService
    {
        private readonly IGenericRepository<Basket> basketRepository;
        private readonly IGenericRepository<Product> productRepository;

        public BasketService(IGenericRepository<Basket> basketRepository, IGenericRepository<Product> productRepository)
        {
            this.basketRepository = basketRepository;
            this.productRepository = productRepository;
        }

        public void Add(Basket basket)
        {
            basket.Active = true;
            basket.DateCreated = DateTime.Now.ToBrazilianTime();
            basket.DateLastUpdate = DateTime.Now.ToBrazilianTime();
            basketRepository.Save(basket);
        }
  
        public void DeleteFirst(int id, int idColor, int idSize, int idLoggedUser)
        {
            var itemBasket = basketRepository.FindFirstBy(item => item.Product.Id == id &&
                item.Size.Id == idSize &&
                item.Color.Id == idColor &&
                item.IdUser == idLoggedUser && item.Active);
            itemBasket.Active = false;
            itemBasket.DateLastUpdate = DateTime.Now.ToBrazilianTime();
            basketRepository.Edit(itemBasket);
        }

        public void InativeAllBy(int idLoggedUser)
        {
            var itensBasket = GetAllActivesBy(idLoggedUser);
            foreach (var basket in itensBasket)
            {
                basket.Active = false;
                basket.DateLastUpdate = DateTime.Now.ToBrazilianTime();
            }
            basketRepository.Edit(itensBasket);
        }

        public IQueryable<Basket> GetAllActivesBy(int idLoggedUser)
        {
            return basketRepository.FindAllBy(b => b.IdUser == idLoggedUser && b.Active).Include(p => p.Size).Include(p => p.Color); 
        }
    }
}