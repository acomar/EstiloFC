using Domain.Entities;
using System.Collections.Generic;

namespace Application.ViewModel
{
    public class SideMenuViewModel
    {
        public IEnumerable<ProductCategory> Menu { get; set; }
    }
}
