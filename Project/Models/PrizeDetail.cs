using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    [Table("prize_detail")]
    public class PrizeDetail
    {
        public int ID_Prize { get; set; }
        public int ID_Competition { get; set; }
        public int Total_Quantity { get; set; }
        public int Total_Price { get; set; }
    }
}
