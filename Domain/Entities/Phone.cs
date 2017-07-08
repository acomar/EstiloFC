using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Phone : BaseEntity
    {
        [Required]
        [MaxLength(2)]
        public string AreaCode
        {
            get;
            set;
        }

        [Required]
        [MaxLength(9)]
        public string Number
        {
            get;
            set;
        }
    }
}
