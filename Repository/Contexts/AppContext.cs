using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Domain.Entities;

namespace Repository.Contexts
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("name=AppContext")
        {
        }

        public DbSet<ProductCategory> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<PaymentType> PaymentsType { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Color> Colors { get; set; } 
        public DbSet<OrderItem> OrderItens { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<StockHistory> StockHistory { get; set; }
        public DbSet<RattingType> RattingType { get; set; }
        public DbSet<ManufacturingData> ManufacturingData { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
