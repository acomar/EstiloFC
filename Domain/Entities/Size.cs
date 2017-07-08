using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Domain.Entities
{
    public class Size: BaseEntity
    {
        [MaxLength(15)]
        public string Name { get; set; }

        
        [MaxLength(2)]
        public string Code { get; set; }
    }
}
