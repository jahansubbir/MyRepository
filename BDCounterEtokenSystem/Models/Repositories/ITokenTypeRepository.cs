using System.Collections.Generic;

namespace BDCounterEtokenSystem.Models.Repositories
{
    public interface ITokenTypeRepository
    {
        IEnumerable<TokenType> GetTokenTypes();
        TokenType GetTokenType(int id);
        TokenType Add(TokenType type);
        TokenType Update(TokenType typeChanges);
        TokenType Delete(int id);
    }
}
