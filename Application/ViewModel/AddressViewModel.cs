using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.ViewModel
{
    public class AddressViewModel
    {
        public string ZipCode { get; set; }
        public string Neighborhood { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Landmark { get; set; }
        public int IdCity { get; set; }
        public int IdUser { get; set; }
    }
}
