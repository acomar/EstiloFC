using System.Web.Mvc;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class OrderViewModel
    {
        
        public ContactViewModel Contact { get; set; }

        public AddressViewModel Address { get; set; }

        public int IdCity { get; set; }
        public City City { get; set; }

        public int IdState { get; set; }
        public State State { get; set; }


        public int IdPaymentType { get; set; }
        public SelectList PaymentType { get; set; }

        public SelectList States { get; set; }
        public SelectList Cities { get; set; }

        public decimal? ChangeFor { get; set; }
        public string PromoCode { get; set; }
        public int IdLoggedUser { get; set; }
    }
}
