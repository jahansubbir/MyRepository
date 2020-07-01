using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BDCounterEtokenSystem.Models.Repositories
{
    public class TokenTypeRepository:ITokenTypeRepository
    {
        private readonly AppDbContext _context;

        public TokenTypeRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<TokenType> GetTokenTypes()
        {
            return _context.TokenTypes;
        }

        public TokenType GetTokenType(int id)
        {
            return _context.TokenTypes.FirstOrDefault(a => a.Id == id);
        }

        public TokenType Add(TokenType type)
        {
            try
            {
                _context.TokenTypes.Add(type);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return type;
        }

        public TokenType Update(TokenType typeChanges)
        {
            TokenType tokenType = null;
            try
            {
                var type = _context.TokenTypes.Attach(typeChanges);
                type.State = EntityState.Modified;
                _context.SaveChanges();
                tokenType = type.Entity;
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return tokenType;
        }

        public TokenType Delete(int id)
        {
            TokenType entity = null;
            try
            {
                 entity = GetTokenType(id);
                if (entity!=null)
                {
                    _context.TokenTypes.Remove(entity);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return entity;

        }
    }
}
