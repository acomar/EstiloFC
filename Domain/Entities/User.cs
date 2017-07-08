using System;
using System.ComponentModel.DataAnnotations;
using Domain.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Infrastructure.Services;
using System.Web;
using System.IO;

namespace Domain.Entities
{
    public class User : BaseRegister
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }


        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(14)]
        public string Cpf { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        public int IdGender { get; set; }

        [ForeignKey("IdGender")]
        public virtual Gender Gender { get; set; }

        [Required]
        [MaxLength(2)]
        public string AreaCode { get; set; }

        [Required]
        [MaxLength(9)]
        public string Number { get; set; }

        public bool IsAdm { get; set; }

        //public int? IdProfile { get; set; }
        //[ForeignKey("IdProfile")]
        //public UserProfile UserProfile { get; set; }

        public int? IdContact { get; set; }

        [ForeignKey("IdContact")]
        public virtual Contact Contact { get; set; }

        public virtual List<Address> Addresses { get; set; }

        public virtual List<Order> Orders { get; set; }

        public void EditPassword(string newPassword)
        {
            this.Password = newPassword;
        }

        public bool ConfirmPassword(string currentPassword)
        {
            return this.Password == currentPassword;
        }

        public void SendEmailForgottenPassword(string sendTo, string password)
        {
            string subject = "Estilo F.C. - Recuperação de Senha";
            string path = HttpContext.Current.Server.MapPath("~/Content/EmailTemplates/ForgottenPassword.html");
            string body = File.ReadAllText(path);
            body = PrepareVariablesInTemplateEmail(body, password);
            Email email = new Email(sendTo, subject, body);
            email.Send();
        }

        public void SendEmailSuccessRegister(string sendTo)
        {
            string subject = "Bem-vindo ao Estilo F.C. - Loja virtual!";
            string path = HttpContext.Current.Server.MapPath("~/Content/EmailTemplates/Register.html");
            string body = File.ReadAllText(path);
            body = PrepareVariablesInTemplateEmail(body);
            Email email = new Email(sendTo, subject, body);
            email.Send();
        }

        private string PrepareVariablesInTemplateEmail(string body, string password = "")
        {
            body = body.Replace("[FirstName]", this.FirstName);
            return body.Replace("[Password]", password);
        }

        public string FullName()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }

        public string CpfNoMask()
        {
            return this.Cpf.Replace(".", "").Replace("-", "");
        }

        
    }
}
