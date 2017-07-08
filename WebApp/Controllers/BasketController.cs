using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Application.Filters;
using Application.Services;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;

namespace WebApp.Controllers
{
    public class BasketController : BaseController
    {
        private readonly BasketService basketService;
        private readonly OrderService orderService;
        private readonly ContactService contactService;
        private readonly UserService userService;
        private readonly AddressService addressService;
        private readonly StockService stockService;
        private readonly IGenericRepository<Order> orderRepository;
        private readonly IGenericRepository<Address> addressRepository;
        private readonly IGenericRepository<City> citiesRepository;
        private readonly IGenericRepository<PromoCode> promoCodeRepository;


        public BasketController(BasketService basketService,
                                    OrderService orderService,
                                    ContactService contactService,
                                    UserService userService,
                                    AddressService addressService,
                                    StockService stockService,
                                    IGenericRepository<Order> orderRepository,
                                    IGenericRepository<Address> addressRepository,
                                    IGenericRepository<City> citiesRepository,
                                    IGenericRepository<PromoCode> promoCodeRepository)
        {
            this.basketService = basketService;
            this.orderService = orderService;
            this.orderRepository = orderRepository;
            this.contactService = contactService;
            this.userService = userService;
            this.addressService = addressService;
            this.addressRepository = addressRepository;
            this.stockService = stockService;
            this.citiesRepository = citiesRepository;
            this.promoCodeRepository = promoCodeRepository;
        }

        public ViewResult Index()
        {
            OrderViewModel orderViewModel = orderService.PopulateViewModel(new Order() { IdUser = IdLoggedUser });
            orderViewModel.Contact = new ContactViewModel();
            if (GetLoggedUser != null)
                orderViewModel.Contact.ContactNumber = GetLoggedUser.Contact != null ? GetLoggedUser.Contact.ContactDescription : null;
            return View(orderViewModel);
        }

        public JsonResult FinalizeOrder(OrderViewModel orderViewModel)
        {
            Order order = new Order();
            try
            {
                orderViewModel.IdLoggedUser = base.IdLoggedUser;
                order = orderService.PopulateModel(orderViewModel);
                order.IdAddress = addressService.SaveOrEditAddress(orderViewModel.Address, base.IdLoggedUser);
                order.OrderItens = orderService.GetOrderItens(order);
                var promoCode = promoCodeRepository.FindFirstBy(c => c.Code == orderViewModel.PromoCode);
                if (promoCode != null)
                    order.IdPromoCode = promoCode.Id;
                if (!stockService.CheckStock(order))
                {
                    basketService.InativeAllBy(order.IdUser);
                    return Json(new { success = false, message = Infrastructure.Resources.CartResource.ErrorStock });
                }

                var url = orderService.Finalize(order);
                return Json(new { success = true, idOrder = order.Id, url = url });
            }
            catch (System.Exception)
            {
                return Json(new { success = false, message = Infrastructure.Resources.CartResource.ErrorFinalize });
            }

        }


        public ViewResult OrderDone(int idOrder)
        {
            ViewBag.UserName = GetLoggedUser.FullName();
            var order = orderService.GetOrder(idOrder, base.IdLoggedUser);

            return View("OrderDone", "_LayoutOrderDone", order);
        }
        [AccessAuthorize]
        public void Add(int id, int idColor, int idSize)
        {
            basketService.Add(new Basket { IdUser = IdLoggedUser, IdProduct = id, IdColor = idColor, IdSize = idSize });
            stockService.IncrementRelevance(id);
        }


        [AccessAuthorize]
        public void Rem(int id, int idColor, int idSize)
        {
            basketService.DeleteFirst(id, idColor, idSize, IdLoggedUser);
        }

        [AccessAuthorize]
        public void Empty()
        {
            basketService.InativeAllBy(IdLoggedUser);
        }
        [AccessAuthorize]
        public decimal Promo(string code)
        {
            var promoCode = promoCodeRepository.FindFirstBy(c => c.Code == code);
            if (promoCode != null)
            {
                var basketList = basketService.GetAllActivesBy(IdLoggedUser).ToList();
                var total = basketList.Sum(c => c.Product.Price.GetSallingPrice());
                return promoCode.GetDiscount(total);
            }
            return 0;
        }

        public JsonResult Get()
        {
            var basketList = basketService.GetAllActivesBy(IdLoggedUser);
            var list = basketList.OrderBy(c => c.Id).ToList().Select(p => new
                                                         {
                                                             id = p.Product.Id,
                                                             name = p.Product.Name,
                                                             size = p.Size.Code,
                                                             idColor = p.Color.Id,
                                                             idSize = p.Size.Id,
                                                             color = p.Color.Name,
                                                             description = p.Product.ProductAndDescription(),
                                                             sellingPrice = p.Product.Price.GetSallingPrice(),
                                                             imagePath = p.Product.ImagePath()
                                                         });
            return Json(list);
        }
        public JsonResult GetCities(int idState)
        {
            var cities = citiesRepository.FindAllBy(c => c.IdState == idState);
            return this.Json(new { cities }, JsonRequestBehavior.AllowGet);
        }
    }
}
