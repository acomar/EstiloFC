using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Infrastructure.Resources;
using System.Web.Mvc;

namespace Application.ViewModel
{
    public class ProductsViewModel : FilterProductViewModel
    {
        
        public List<Product> Products { get; set; }
        public Product FirstProduct
        {
            get
            {
                return this.Products == null ? null : this.Products.FirstOrDefault();
            }
        }
        public ProductsViewModel()
        {
            this.NumberPerPage = 100;
            this.Skip = 0;
        }

        public object NoProductsMessage()
        {
            var message = string.Empty;
            if (AnyItens() && !string.IsNullOrEmpty(this.SearchText))
                message = string.Format(ProductResource.NoResults, this.SearchText);
            return message;
        }

        public bool AnyItens()
        {
            return Products.Count == 0;
        }

    }
    public abstract class PaginationViewModel
    {
        public int NumberPerPage { get; set; }
        public int Skip { get; set; }
        public string NextAction { get; set; }
    }

    public class FilterProductViewModel : PaginationViewModel
    {
        public string NameCategory { get; set; }
        public string NameRootCategory { get; set; }
        public int IdProductCategory { get; set; }
        public string SearchText { get; set; }
    }
}