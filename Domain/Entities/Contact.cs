using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Contact : BaseEntity
    {

        
        //public int IdContactForm { get; set; }
        //[ForeignKey("IdContactForm")]
        //public virtual ContactForm ContactForm { get; set; }

        [Required]
        [MaxLength(20)]
        public string ContactDescription { get; set; }
    }
}
