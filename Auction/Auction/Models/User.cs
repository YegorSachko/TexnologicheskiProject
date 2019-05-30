using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Auction.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Login { get; set; }
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string password { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string address { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string name { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string fam { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string otc { get; set; }
    }
}
