using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Address : BaseEntity
    {
        [Required]
        [MaxLength(20)]
        public string ZipCode { get; set; }

        [Required]
        public int IdCity { get; set; }
        public virtual  City City { get; set; }

        [Required]
        [MaxLength(100)]
        public string Street { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        [MaxLength(50)]
        public string Neighbornhood { get; set; }

        [MaxLength(100)]
        public string Complement { get; set; }

        [Required]
        public int IdUser { get; set; }
        public string User { get; set; }

        public string GetFullAddress()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("<p><b>Telefone:</b> {0}</p>", this.Number));
            sb.AppendLine(string.Format("<p><b>CEP:</b> {0}</p>", this.ZipCode));
            sb.AppendLine(string.Format("<p><b>Endereço:</b> {0}</p>", this.Street));
            sb.AppendLine(string.Format("<p><b>Número:</b> {0}</p>", this.Number));
            sb.AppendLine(string.Format("<p><b>Complemento:</b> {0}</p>", this.Complement));
            sb.AppendLine(string.Format("<p><b>Bairro:</b> {0}</p>", this.Neighbornhood));
            sb.AppendLine(string.Format("<p><b>Estado:</b> {0}</p>", this.City.State.Uf));
            sb.AppendLine(string.Format("<p><b>Cidade:</b> {0}</p>", this.City.Name));
            return sb.ToString();
        }
    }
}
