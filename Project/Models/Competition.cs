using Microsoft.AspNetCore.Http;
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
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Content { get; set; }

        [DisplayName("Start")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_Start { get; set; }

        [DisplayName("End")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date_End { get; set; }

        public string Image { get; set; }

        [NotMapped]
        [DisplayName("Upload Image")]
        [Required(ErrorMessage = "This field is required.")]
        public IFormFile ImageFile { get; set; }

        public bool? Status { get; set; }

        public IEnumerable<Competition> getAll() => new Context().Competitions.ToList();
        public IEnumerable<Post> getAllPost(int id) => new Context().Posts.Where(q => q.ID_Competition == id).ToList();
    }
}
