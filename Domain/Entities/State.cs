using Domain.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class State : BaseEntity
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(2)]
        public string  Uf { get; set; }
        public virtual List<City> Cities { get; set; }
    }
}
