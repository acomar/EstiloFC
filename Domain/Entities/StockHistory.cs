using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Base;
using Infrastructure.Extensions;
namespace Domain.Entities
{
    public class StockHistory : BaseRegister
    {

        public StockHistory(Stock stock)
        {
            this.IdProduct = stock.IdProduct;
            this.IdSize = stock.IdSize;
            this.IdColor = stock.IdColor;
            this.Quantity = stock.Quantity;
            this.Active = true;
            this.DateCreated = DateTime.Now.ToBrazilianTime();
            this.DateLastUpdate = DateTime.Now.ToBrazilianTime();
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

    }
}