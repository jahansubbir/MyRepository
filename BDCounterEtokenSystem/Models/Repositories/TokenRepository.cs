using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BDCounterEtokenSystem.Models.Repositories
{
    public class TokenRepository : ITokenRepository
    {
        private readonly AppDbContext _context;

        public TokenRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Token> GetTokens()
        {
            IEnumerable<Token> tokens = null;
            try
            {
                tokens = _context.Tokens;
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return tokens;
        }

        public IEnumerable<Token> GeTokensByCounter(string counterId)
        {
            IEnumerable<Token> tokens = null;
            try
            {
                tokens = _context.Tokens.Where(a => a.CounterId == counterId);
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return tokens;
        }

        public IEnumerable<Token> GetTokensByType(int typeId)
        {
            IEnumerable<Token> tokens = null;
            try
            {
                tokens = _context.Tokens.Where(a => a.TypeId == typeId);
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return tokens;
        }

        public Token GetToken(int id)
        {
            Token token = null;
            try
            {
                token = _context.Tokens.Find(id);
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return token;
        }

        public Token Add(Token token, List<TokenDetail> details)
        {
            var transaction = _context.Database.BeginTransaction();
            try
            {
                
                _context.Tokens.Add(token);
                _context.SaveChanges();
                var t = _context.Tokens.Find(token);
                foreach (TokenDetail detail in details)
                {
                    detail.TokenId = t.Id;
                    _context.TokenDetails.Add(detail);
                    _context.SaveChanges();
                }
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                ExceptionLogger.Log(e);
            }

            return token;
        }

        public Token Add(Token token)
        {
            try
            {
                _context.Tokens.Add(token);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return token;
        }

        public Token Update(Token tokenChanges)
        {
            //  EntityEntry<Token> token = null;
            try
            {
                var token = _context.Tokens.Attach(tokenChanges);
                token.State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return tokenChanges;
        }

        public Token Delete(int tokenId)
        {
            Token token = null;
            try
            {
                token = _context.Tokens.Find(tokenId);
                if (token != null)
                {
                    _context.Tokens.Remove(token);
                }

                _context.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return token;
        }
    }
}
