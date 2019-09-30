using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.Models
{
    public class Bit
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        
        public int LotId { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public int Price { get; set; }
        public User User { get; set; }
    }
}
