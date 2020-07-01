using System.ComponentModel.DataAnnotations.Schema;

namespace BDCounterEtokenSystem.Models
{
    public class TokenDetail
    {
        public int Id { get; set; }
        [ForeignKey("Token")]
        public int TokenId { get; set; }
        public string DocumentNo { get; set; }

        public Token Token { get; set; }
    }
}
