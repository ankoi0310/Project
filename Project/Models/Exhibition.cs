using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Table("exhibition")]
    public class Exhibition
    {
        public int ID { get; set; }
    }
}
