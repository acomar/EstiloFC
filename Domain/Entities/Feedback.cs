using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Feedback : BaseRegister
    {
        public int? IdUser { get; set; }
        [ForeignKey("IdUser")]
        public User user { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
