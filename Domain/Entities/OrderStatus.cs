using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Domain.Entities
{
    public class OrderStatus : BaseEntity
    {
        [MaxLength(300)]
        public string Definition { get; set; }

        [MaxLength(35)]
        public string Description { get; set; }


        [MaxLength(25)]
        public string Key { get; set; }
    }
  
}
