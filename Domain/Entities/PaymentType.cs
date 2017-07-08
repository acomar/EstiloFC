using System.ComponentModel.DataAnnotations;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class PaymentType : BaseEntity
    {
        [Required]
        [MaxLength(20)]
        public string Key { get; set; }

        [Required]
        [MaxLength(30)]
        public string Description { get; set; }
    }
}
