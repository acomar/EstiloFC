using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Infrastructure.Resources;
using System.Web.Mvc;

namespace Application.ViewModel
{

    public class CollectionViewModel
    {
        public CollectionViewModel(Product item)
        {
            this.Product = item;
        }
        public Product Product;
        public bool IHave { get; set; }
        public string GetIHave() {
            if (IHave)
            {
                return "Eu tenho";
            }
            return "Não tenho";
        }
    }
}