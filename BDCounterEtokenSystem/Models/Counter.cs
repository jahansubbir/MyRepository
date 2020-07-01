using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDCounterEtokenSystem.Models
{
    public class Counter
    {
        [Key]
        [Column(TypeName = "varchar(30)")]
        [MaxLength(30,ErrorMessage = "Maximum 30 Character")]
        
        public string Name { get; set; }

        public int BoothCount { get; set; }

    }
}
