using Domain.Entities.Base;
using System.Globalization;

namespace Domain.Entities
{
    public class Price : BaseEntity
    {
        public decimal Cost { get; set; }
        public decimal Selling { get; set; }
        public decimal? Promotial { get; set; }
        public bool OnSale { get; set; }

        public decimal GetSallingPrice()
        {
            decimal price = 0;
            if (OnSale && Promotial.HasValue)            
                price = Promotial.Value;            
            else            
                price = Selling;            
            return price;
        }
        public string GetInstallment(int parcel)
        {
            decimal price = 0;
            if (OnSale && Promotial.HasValue)            
                price = Promotial.Value;            
            else            
                price = Selling;
            return string.Format("Ou em até {0}x de {1} sem juros", parcel, (price / parcel).ToString("C", new CultureInfo("pt-BR")));
        }
        
    }
}