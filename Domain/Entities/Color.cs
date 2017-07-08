using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Color : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string HexaColor1 { get; set; }
        [MaxLength(10)]
        public string HexaColor2 { get; set; }
    }
}
