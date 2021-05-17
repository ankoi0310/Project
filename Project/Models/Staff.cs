using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Table("staff")]
    public class Staff
    {
        public string ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }

        [DisplayName("Date or birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_Of_Birth { get; set; }

        public bool Gender { get; set; }

        [DisplayName("Date start ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Start_Date { get; set; }

        public string Password { get; set; }

        [DisplayName("Position ")]
        public int ID_Position { get; set; }
    }
}
