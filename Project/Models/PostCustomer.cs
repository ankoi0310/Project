using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Table("post_customer")]
    public class PostCustomer
    {
        public int ID_Post { get; set; }

        public int ID_Customer { get; set; }

        public DateTime Date { get; set; }
    }
}
