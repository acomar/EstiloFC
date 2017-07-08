using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Web;
using Domain.Entities.Base;
using Infrastructure.Services;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string ComplementName { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Brand { get; set; }

        [MaxLength(40)]
        public string ImageName { get; set; }

        public int IdPrice { get; set; }

        [ForeignKey("IdPrice")]
        public virtual Price Price { get; set; }

        public int IdProductCategory { get; set; }

        [ForeignKey("IdProductCategory")]
        public virtual ProductCategory ProductCategory { get; set; }

        public bool Active { get; set; }

        public int Relevance { get; set; }

        [MaxLength(15)]
        public string Type { get; set; }




        public int? IdManufacturingData { get; set; }

        [ForeignKey("IdManufacturingData")]
        public virtual ManufacturingData ManufacturingData { get; set; }

        public string ProductAndDescription()
        {
            return string.Format("{0} - {1}", this.Name, this.Description);
        }
        public string ImagePath(bool iHave = false)
        {
            var path = Path.ProductImages();
            path = VirtualPathUtility.ToAbsolute(path);
            path = string.Concat(path, this.ImageName);

            return path;
        }



        public string NameForRoute
        {
            get
            {
                return this.Name.TrimStart().TrimEnd().Replace("?", "").Replace("&", " e ").Replace("ê", "e").Replace(" ", "").Replace("-", "").Replace(",", "").ToLower();
            }
        }


    }
}
