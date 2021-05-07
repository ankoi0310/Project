using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Table("customer")]
    public class Customer
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }

        public bool Gender { get; set; }

        [DisplayName("Date of birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_Of_Birth { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Phone { get; set; }
    }
}
