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
    public class Reserve : BaseEntity
    {
        public int IdContact{ get; set; }

        [ForeignKey("IdContact")]
        public virtual Contact Contact { get; set; }

        public int IdUser { get; set; }

        [ForeignKey("IdUser")]
        public virtual User User { get; set; }

        public int IdProduct { get; set; }

        [ForeignKey("IdProduct")]
        public virtual Product Product { get; set; }

        public int IdSize { get; set; }

        [ForeignKey("IdSize")]
        public Size Size { get; set; }
    }
}
