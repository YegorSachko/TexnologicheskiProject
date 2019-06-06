using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.Models
{
    public class Lot
    {
        [Key]
        public int LotID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Lotname { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(2000)")]
        public string LotUrl { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Lotprice { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string LotOwner { get; set; }
   
    }

}
