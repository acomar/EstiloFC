using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Login : BaseEntity
    {
        public Login()
        {
        }

        public Login(User user)
        {
            this.User = user;
        }
        
        public int IdUser { get; set; }

        [ForeignKey("IdUser")]
        public User User { get; set; }

        [Required]
        public DateTime DateLogin { get; set; }

        public bool LoginUser(User user)
        {
            return user != null && this.User.Password == user.Password;
        }
        public bool LoginAdmUser(User user)
        {
            return user != null && this.User.Password == user.Password && user.IsAdm;
        }
    }
}