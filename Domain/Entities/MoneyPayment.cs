using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceFacil.Domain.Entities
{
    public class MoneyPayment : Payment
    {
        public decimal? ChangeFor { get; set; }
    }
}
