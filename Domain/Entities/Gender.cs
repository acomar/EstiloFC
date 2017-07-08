using System.ComponentModel.DataAnnotations;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Gender : BaseEntity
    {
        [Required]
        [MaxLength(10)]
        public string Name { get; set; }
    }
}
