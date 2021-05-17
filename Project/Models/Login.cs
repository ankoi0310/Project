using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Login
    {
        [Required(ErrorMessage = "This field is required.")]
        public string ID { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Password { get; set; }
    }
}
