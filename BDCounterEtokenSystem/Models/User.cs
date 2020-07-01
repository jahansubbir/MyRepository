using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDCounterEtokenSystem.Models
{
    public class User
    {
        [Key]
        [Column(TypeName = "varchar(10)")]
        [MaxLength(10)]
        public string UId { get; set; }
        
        public string Role { get; set; }

    }
}
