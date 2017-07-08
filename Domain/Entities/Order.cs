using Domain.Entities.Base;
using Domain.Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;

namespace Domain.Entities
{
    public class Order : BaseRegister
    {
        public Order()
        {
            var statusCanceled = 7;
            if (this.IdOrderStatus == 0)
                this.IdOrderStatus = statusCanceled;
        }
        public int IdUser { get; set; }

        [ForeignKey("IdUser")]
        public User User { get; set; }

        public int IdAddress { get; set; }

        [ForeignKey("IdAddress")]
        public virtual Address Address { get; set; }

        public List<OrderItem> OrderItens { get; set; }

        [DefaultValue(1)]
        public int IdOrderStatus { get; set; }

        [ForeignKey("IdOrderStatus")]
        public virtual OrderStatus OrderStatus { get; set; }


        public int? IdPromoCode { get; set; }

        [ForeignKey("IdPromoCode")]
        public virtual PromoCode PromoCode { get; set; }

        public decimal GetTotalValue()
        {
            var total = OrderItens.Sum(orderItem => orderItem.Product.Price.GetSallingPrice());
            return total - PromoCode.GetDiscount(total);
        }

        public bool IfItWasNotCanceledAndIsNow(OrderStatusEnum oldStatus, OrderStatusEnum newStatus)
        {
            return oldStatus != OrderStatusEnum.CANCELADA && newStatus == OrderStatusEnum.CANCELADA;
        }

        public bool IfItWasCanceledAndNowItIsNot(OrderStatusEnum oldStatus, OrderStatusEnum newStatus)
        {
            return oldStatus == OrderStatusEnum.CANCELADA && newStatus != OrderStatusEnum.CANCELADA;
        }


        public string GetDiscount()
        {
            decimal discount = 0 ;
            if (PromoCode != null && this.OrderItens != null && this.OrderItens.Count > 0)
                discount = this.PromoCode.GetDiscount(this.OrderItens.Sum(c => c.TotalPrice));
            return discount.ToString("C", new CultureInfo("pt-BR"));
        }
    }
}
