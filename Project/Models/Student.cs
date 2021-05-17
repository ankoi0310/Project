using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Table("student")]
    public class Student
    {
        public string ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }

        [DisplayName("Date or birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_Of_Birth { get; set; }

        public bool Gender { get; set; }

        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Classroom")]
        public int ID_Class_Room { get; set; }

        [DisplayName("Position")]
        public int ID_Position { get; set; }
    }
}
