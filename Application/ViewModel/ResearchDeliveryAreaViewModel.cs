using System;

using Domain.Entities;
using System.Web.Mvc;

namespace Application.ViewModel
{
    public class ResearchDeliveryAreaViewModel 
    {
        public SelectList DeliveryArea { get; set; }

        public int IdDeliveryArea { get; set; }

        public string OtherDeliveryArea { get; set; }

        public string Ip { get; set; }

        public int IdUser { get; set; }
    }
}