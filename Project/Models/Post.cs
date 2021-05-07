using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Table("post")]
    public class Post
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Image { get; set; }

        [DisplayName("Author")]
        [Required(ErrorMessage = "This field is required.")]
        public int ID_Student { get; set; }

        [DisplayName("Date upload")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_Upload { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Description { get; set; }

        [DisplayName("Competition")]
        [Required(ErrorMessage = "This field is required.")]
        public int ID_Competition { get; set; }

        [DisplayName("Exhibition")]
        public int? ID_Exhibition { get; set; }

        public int? Price { get; set; }

        public string Rate { get; set; }

        public string Comment { get; set; }

        [DisplayName("Sale status")]
        public bool? Sale_Status { get; set; }
    }
}
