using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BDCounterETokenSystem.Models;

namespace BDCounterEtokenSystem.Models
{
    public class Token
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Counter")]
        public string CounterId { get; set; }
        [ForeignKey("Booth")]
        public int BoothId { get; set; }

        [ForeignKey("TokenType")]
        public int TypeId { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime AppointmentTime { get; set; }
        [Column(TypeName = "varchar(20)")]
        [MaxLength(20)]
        public string TokenNumber { get; set; }
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string RequestSlot { get; set; }

        public Counter Counter { get; set; }
        public Booth Booth { get; set; }
        public TokenType TokenType { get; set; }
    }
}
