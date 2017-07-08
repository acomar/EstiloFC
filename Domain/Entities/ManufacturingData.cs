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
    public class ManufacturingData : BaseEntity
    {
        [MaxLength(5000)]
        public string History { get; set; }
        public int IdRatting { get; set; }
        [ForeignKey("IdRatting")]
        public virtual RattingType Ratting { get; set; }
         [MaxLength(100)]
        public string ColletionName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Drawing { get; set; }
    }
}
