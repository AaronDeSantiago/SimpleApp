using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleApp.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public string ModelName { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }

        public int PersonId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Owner { get; set; }
    }
}