using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Base
{
    public class BaseRegister : BaseEntity
    {
        [Required]
        public virtual DateTime DateCreated { get; set; }

        [Required]
        public virtual DateTime DateLastUpdate { get; set; }

        [Required]
        public virtual bool Active { get; set; }
    }
}
