using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Domain.Entities
{
    public class City : BaseEntity
    {
        public City()
        {
            //this.State = new State();
        }
        [MaxLength(75)]
        public string Name { get; set; }

        public int IdState { get; set; }
        [ForeignKey("IdState")]
        public State State { get; set; }
    }
}
