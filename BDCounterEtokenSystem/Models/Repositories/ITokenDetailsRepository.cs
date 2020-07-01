using System.Collections.Generic;

namespace BDCounterEtokenSystem.Models.Repositories
{
   public interface ITokenDetailsRepository
   {
       IEnumerable<TokenDetail> GetTokenDetails();
       TokenDetail Add(TokenDetail detail);
       TokenDetail Update(TokenDetail detailChanges);
       TokenDetail Delete(int id);
   }
}
