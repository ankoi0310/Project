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
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Date or birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_Of_Birth { get; set; }

        public bool Gender { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Date start ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Start_Date { get; set; }

        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Position ")]
        public int ID_Position { get; set; }
        public string GetPositionName(int id) => new Context().Positions.Find(id).Name;
    }
}
