using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BDCounterEtokenSystem.Models.Repositories
{
    public class TokenDetailsRepository: ITokenDetailsRepository
    {
        private readonly AppDbContext _context;

        public TokenDetailsRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<TokenDetail> GetTokenDetails()
        {
            return _context.TokenDetails;
        }

        public TokenDetail Add(TokenDetail detail)
        {
            try
            {
                _context.TokenDetails.Add(detail);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return detail;
        }

        public TokenDetail Update(TokenDetail detailChanges)
        {
            try
            {
                var detail = _context.TokenDetails.Attach(detailChanges);
                detail.State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return detailChanges;
        }

        public TokenDetail Delete(int id)
        {
            TokenDetail detail = null;
            try
            {
                 detail = _context.TokenDetails.Find(id);
                if (detail!=null)
                {
                    _context.TokenDetails.Remove(detail);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return detail;
            //return null;
        }
    }
}
