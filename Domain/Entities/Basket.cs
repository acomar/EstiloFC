using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Basket : BaseRegister
    {
        public int IdUser { get; set; }

        [ForeignKey("IdUser")]
        public virtual User User { get; set; }

        public int IdProduct { get; set; }

        [ForeignKey("IdProduct")]
        public virtual Product Product { get; set; }

        public int IdSize { get; set; }
        [ForeignKey("IdSize")]
        public Size Size { get; set; }

        public int IdColor { get; set; }
        [ForeignKey("IdColor")]
        public Color Color { get; set; }
    }
}
