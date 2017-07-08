using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public int IdOrder { get; set; }

        [ForeignKey("IdOrder")]
        public Order Order { get; set; }

        public int IdProduct { get; set; }

        [ForeignKey("IdProduct")]
        public Product Product { get; set; }

        public int IdColor { get; set; }
        [ForeignKey("IdColor")]
        public Color Color { get; set; }

        public int IdSize { get; set; }
        [ForeignKey("IdSize")]
        public Size Size { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }

    }
}