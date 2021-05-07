using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Table("competition")]
    public class Competition
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Topic { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Start")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_Start { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("End")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_End { get; set; }

        public bool? Status { get; set; }
    }
}
