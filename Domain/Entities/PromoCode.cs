using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PromoCode : BaseEntity
    {
        public string Code { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public PromoTypeEnum PromoType { get; set; }
        public decimal Value { get; set; }

        public bool IsValid()
        {
            return DateTime.Now <= ExpirationDate;
        }

        public decimal GetDiscount(decimal total)
        {


            decimal discount = 0;
            if (IsValid())
            {
                switch (PromoType)
                {
                    case PromoTypeEnum.Percent:
                        discount = total * (Value / 100);
                        break;
                    case PromoTypeEnum.Value:
                        discount = Value;
                        break;
                }
            }
            return discount;

        }
    }

}
