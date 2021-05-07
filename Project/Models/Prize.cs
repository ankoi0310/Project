using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Table("prize")]
    public class Prize
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Attachment { get; set; }
        public int Attachment_Price { get; set; }
        public int Quantity { get; set; }
    }
}
