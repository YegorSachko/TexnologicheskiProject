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
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Lotname { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(2000)")]
        public string LotUrl { get; set; }
        [Required]
        public int Lotprice { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string LotOwner { get; set; }
        public ICollection<Bit> Bits { get; set; }
    }

}
