using System;
using Domain.Entities;

namespace Application.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime Birthday { get; set; }

        public Gender Gender { get; set; }
      
        public string AreaCode{ get; set; }

        public string Number{ get; set; }
     

    }
}