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
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Login { get; set; }
        [Required]
        [Column(TypeName = "varchar(5)")]
        public string Password { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Address { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Fam { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Otc { get; set; }

        public ICollection<Bit> Bits{get;set;}
    }
    }

