using System.Collections.Generic;

namespace BDCounterEtokenSystem.Models.Repositories
{
   public  interface ITokenRepository
   {
       IEnumerable<Token> GetTokens();
       IEnumerable<Token> GeTokensByCounter(string counterId);
       IEnumerable<Token> GetTokensByType(int typeId);
       
       Token GetToken(int id);
       Token Add(Token token,List<TokenDetail>details);
       Token Update(Token tokenChanges);
       Token Delete(int tokenId);
   }
}
