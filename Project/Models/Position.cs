using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Table("position")]
    public class Position
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
