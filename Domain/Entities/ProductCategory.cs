using Domain.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ProductCategory : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int? IdRootCategory { get; set; }
        [ForeignKey("IdRootCategory")]
        public virtual ProductCategory RootCategory { get; set; }

        public bool Active { get; set; }

        public virtual List<ProductCategory> ProductCategoryChields { get; set; }

        public string NameForRoute
        {
            get
            {
                return this.Name.TrimStart().TrimEnd().Replace("?", "").Replace("&", " e ").Replace("ê","e").Replace(" ", "").Replace("-", "").Replace(",","").ToLower();
            }
        }
    }
}
