using System;
using Application.ViewModel;
using Domain.Entities;
using Repository.Repositories.BaseRepository;
using System.Linq;
using Application.Extensions;
using System.Collections.Generic;
using Infrastructure.Services;
using System.Text;
using System.IO;
using System.Web;
using System.Data.Entity;
using Uol.PagSeguro.Resources;
using Uol.PagSeguro.Domain;
using Uol.PagSeguro.Constants;
using Uol.PagSeguro.Exception;
using Infrastructure.Extensions;
using Uol.PagSeguro.Service;
using Domain.Enums;
namespace Application.Services
{
    public class OrderService : IPopulateModel<Order, OrderViewModel>, IPopulateViewModel<Order, OrderViewModel>
    {
        private readonly IGenericRepository<Product> productRepository;
        private readonly IGenericRepository<Order> orderRepository;
        private readonly IGenericRepository<City> cityRepository;
        private readonly IGenericRepository<Domain.Entities.Address> addressRepository;
        private readonly IGenericRepository<Contact> contactRepository;
        private readonly IGenericRepository<OrderItem> orderItemRepository;
        private readonly IGenericRepository<State> stateRepository;
        private readonly IGenericRepository<User> userRepository;
        private readonly IGenericRepository<OrderStatus> orderStatusRepository;

        private readonly BasketService basketService;
        private readonly UserService userService;
        private readonly ContactService contactService;
        private readonly StockService stockService;


        public OrderService(IGenericRepository<Order> orderRepository,
                                IGenericRepository<City> cityRepository,
                                IGenericRepository<Domain.Entities.Address> addressRepository,
                                IGenericRepository<Contact> contactRepository,
                                IGenericRepository<OrderItem> orderItemRepository,
                                IGenericRepository<State> stateRepository,
                                IGenericRepository<User> userRepository,
                                IGenericRepository<Product> productRepository,
                                IGenericRepository<OrderStatus> orderStatusRepository,
                                BasketService basketService,
                                UserService userService,
                                ContactService contactService,
                                StockService stockService)
        {
            this.orderRepository = orderRepository;
            this.cityRepository = cityRepository;
            this.addressRepository = addressRepository;
            this.basketService = basketService;
            this.orderItemRepository = orderItemRepository;
            this.userService = userService;
            this.contactService = contactService;
            this.contactRepository = contactRepository;
            this.stateRepository = stateRepository;
            this.userRepository = userRepository;
            this.productRepository = productRepository;
            this.stockService = stockService;
            this.orderStatusRepository = orderStatusRepository;
        }

        public Order PopulateModel(OrderViewModel viewModel)
        {
            Order order = new Order();
            order.IdUser = viewModel.IdLoggedUser;
            return order;
        }
        public OrderViewModel PopulateViewModel(Order order)
        {
            OrderViewModel orderViewModel = new OrderViewModel();
            orderViewModel.States = stateRepository.GetAll().ToList().ToSelectList(x => x.Uf, a => a.Id);
            order = orderRepository.FindAllBy(x => x.IdUser == order.IdUser && x.Active).Include(p => p.Address.City).ToList().LastOrDefault();

            if (order == null)
                return orderViewModel;
            orderViewModel.Address = new AddressViewModel();
            orderViewModel.Address.ZipCode = order.Address.ZipCode;
            orderViewModel.Address.Address = order.Address.Street;
            orderViewModel.Address.Complement = order.Address.Complement;
            orderViewModel.Address.Neighborhood = order.Address.Neighbornhood;
            orderViewModel.Address.Number = order.Address.Number;
            orderViewModel.IdCity = order.Address.IdCity;
            var city = cityRepository.Find(order.Address.IdCity);
            if (city != null)
                orderViewModel.IdState = city.IdState;
            orderViewModel.City = new City();
            orderViewModel.State = new State();
            return orderViewModel;
        }
        public Order GetOrder(int idOrdem, int idUser)
        {
            var order = orderRepository.FindAllBy(x => x.IdUser == idUser && x.Id == idOrdem)
                                                    .Include(p => p.Address)
                                                    .Include(p => p.User)
                                                    .Include(p => p.OrderStatus)
                                                    .Include(p => p.PromoCode)
                                                    .ToList().First();
            order.OrderItens = orderItemRepository.FindAllBy(x => x.IdOrder == order.Id)
                                                    .Include(p => p.Product.Price)
                                                    .Include(p => p.Size)
                                                    .Include(p => p.Color)
                                                    .ToList();
            order.Address.City = cityRepository.Find(order.Address.IdCity);
            order.Address.City.State = stateRepository.Find(order.Address.City.IdState);
            order.User = userRepository.Find(order.IdUser);
            return order;

        }
        public List<Order> GetOrders(int idUser)
        {
            var orders = orderRepository.FindAllBy(x => x.IdUser == idUser)
                                                    .Include(p => p.Address)
                                                    .Include(p => p.User)
                                                    .Include(p => p.OrderStatus)
                                                    .Include(p => p.PromoCode)
                                                    .ToList();
            foreach (var order in orders)
            {
                order.OrderItens = orderItemRepository.FindAllBy(x => x.IdOrder == order.Id)
                                                  .Include(p => p.Product.Price)
                                                  .Include(p => p.Size)
                                                  .Include(p => p.Color)
                                                  .ToList();
            }

            return orders;

        }
        public string Finalize(Order order)
        {
            SaveOrder(order);
            order = GetOrder(order.Id, order.IdUser);
            var url = CreatePayment(order);
            basketService.InativeAllBy(order.IdUser);
            return url;
        }



        public int SaveContact(Contact contact)
        {
            return contactRepository.Save(contact);
        }
        public int SaveOrder(Order order)
        {
            order.DateCreated = DateTime.Now.ToBrazilianTime();
            order.DateLastUpdate = DateTime.Now.ToBrazilianTime();
            order.Active = true;
            return orderRepository.Save(order);
        }
        public void SaveOrderItens(Order order)
        {
            order.OrderItens = null;
            var basketList = basketService.GetAllActivesBy(order.IdUser)
                                .GroupBy(x => new { x.IdProduct, x.IdColor, x.IdSize })
                                .Select(g => new { IdProduct = g.Key.IdProduct, Quantity = g.Count(), Color = g.Key.IdColor, Size = g.Key.IdSize })
                                .ToList();


            List<OrderItem> orderItens = new List<OrderItem>();
            basketList.ForEach(x => orderItens.Add(new OrderItem()
            {
                IdOrder = order.Id,
                IdProduct = x.IdProduct,
                UnitPrice = productRepository.Find(x.IdProduct).Price.GetSallingPrice(),
                Quantity = x.Quantity,
                IdColor = x.Color,
                IdSize = x.Size
            }));
            orderItens.ForEach(x => orderItemRepository.Add(x));
            orderItemRepository.Save();
        }

        public List<OrderItem> GetOrderItens(Order order)
        {
            var basketList = basketService.GetAllActivesBy(order.IdUser)
                                .GroupBy(x => new { x.IdProduct, x.IdColor, x.IdSize })
                                .Select(g => new { IdProduct = g.Key.IdProduct, Quantity = g.Count(), Color = g.Key.IdColor, Size = g.Key.IdSize })
                                .ToList();


            List<OrderItem> orderItens = new List<OrderItem>();
            basketList.ForEach(x => orderItens.Add(new OrderItem()
            {
                IdOrder = order.Id,
                IdProduct = x.IdProduct,
                UnitPrice = productRepository.Find(x.IdProduct).Price.GetSallingPrice(),
                Quantity = x.Quantity,
                IdColor = x.Color,
                IdSize = x.Size
            }));
            return orderItens;
        }

        public void SaveOrEditUserContact(User loggedUser, ContactViewModel contactViewModel)
        {
            Contact newContact = contactService.PopulateModel(contactViewModel);
            if (loggedUser.Contact == null)
                CreateNewContact(newContact, loggedUser);
            else
                contactService.Edit(newContact);
        }

        private void CreateNewContact(Contact contact, User loggedUser)
        {
            int idContact = contactService.Save(contact);
            userService.EditUserContact(loggedUser.Id, idContact);
            loggedUser.Contact = contact;
        }

        private string CreatePayment(Order order)
        {
            bool isSandbox = false;

            EnvironmentConfiguration.ChangeEnvironment(isSandbox);

            try
            {

                AccountCredentials credentials = PagSeguroConfiguration.Credentials(isSandbox);
                PaymentRequest payment = new PaymentRequest();
                payment.Currency = Currency.Brl;

                foreach (var item in order.OrderItens)
                {
                    var itemName = string.Format("{0}-{1} | {2} ", item.Product.Name, item.Product.ComplementName, item.Size.Code);
                    payment.Items.Add(new Item(item.Product.Id.ToString(), itemName, item.Quantity, item.Product.Price.GetSallingPrice()));
                }
                var total = payment.Items.Sum(c => (c.Amount * c.Quantity));
                if (order.PromoCode != null)
                    payment.ExtraAmount = -order.PromoCode.GetDiscount(total);
                // Sets a reference code for this payment request, it is useful to identify this payment in future notifications.
                payment.Reference = order.Id.ToString();

                // Sets shipping information for this payment request
                payment.Shipping = new Shipping();
                payment.Shipping.ShippingType = ShippingType.NotSpecified;

                //Passando valor para ShippingCost
                payment.Shipping.Cost = 0.00m;

                payment.Shipping.Address = new Uol.PagSeguro.Domain.Address(
                    "BRA",
                    order.Address.City.State.Uf,
                    order.Address.City.Name,
                    order.Address.Neighbornhood,
                    order.Address.ZipCode,
                    order.Address.Street,
                    order.Address.Number,
                    order.Address.Complement
                );

                // Sets your customer information.
                payment.Sender = new Sender(
                  "",
                  order.User.Email,
                  new Uol.PagSeguro.Domain.Phone(order.User.AreaCode, order.User.Number)
                );

                // Sets the url used by PagSeguro for redirect user after ends checkout process
                payment.RedirectUri = new Uri("http://www.estilofc.com.br/Order/Done");

                SenderDocument senderCPF = new SenderDocument(Documents.GetDocumentByType("CPF"), order.User.CpfNoMask());
                payment.Sender.Documents.Add(senderCPF);


                Uri paymentRedirectUri = payment.Register(credentials);
                return paymentRedirectUri.ToString();
            }
            catch (PagSeguroServiceException exception)
            {
                stockService.Add(order);
                throw exception;
            }
        }


        public void Notification(string idTransaction)
        {
            bool isSandbox = false;
            EnvironmentConfiguration.ChangeEnvironment(isSandbox);
            try
            {
                AccountCredentials credentials = PagSeguroConfiguration.Credentials(isSandbox);
                Transaction transaction = NotificationService.CheckTransaction(credentials, idTransaction, false);
                int idOrder = Convert.ToInt32(transaction.Reference);
                var newStatus = (OrderStatusEnum)transaction.TransactionStatus;
                var order = orderRepository.Find(idOrder);
                var oldStatus = (OrderStatusEnum)order.IdOrderStatus;
                order.IdOrderStatus = (int)newStatus;
                orderRepository.Edit(order);
                UpdateStock(order, oldStatus, newStatus);

            }
            catch (PagSeguroServiceException exception)
            {
                throw exception;
            }
        }

        private void UpdateStock(Order order, OrderStatusEnum oldStatus, OrderStatusEnum newStatus)
        {
            if (order.IfItWasNotCanceledAndIsNow(oldStatus, newStatus))
                stockService.Add(order);
            else if (order.IfItWasCanceledAndNowItIsNot(oldStatus, newStatus))
                stockService.Remove(order);
        }

    }
}