using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Stock : BaseEntity
    {
        public Stock()
        {
        }

        public int IdProduct { get; set; }

        [ForeignKey("IdProduct")]
        public Product Product { get; set; }

        public int IdSize { get; set; }

        [ForeignKey("IdSize")]
        public Size Size { get; set; }

        public int IdColor { get; set; }
        [ForeignKey("IdColor")]
        public Color Color { get; set; }

        public int Quantity { get; set; }

        public bool InStock(int quantity)
        {
            return this.Quantity >= quantity;
        }
    }
}