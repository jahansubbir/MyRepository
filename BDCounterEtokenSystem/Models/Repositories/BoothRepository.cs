using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDCounterEtokenSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BDCounterETokenSystem.Models.Repositories
{
    public class BoothRepository:IBoothRepository
    {
        private readonly AppDbContext _context;

        public BoothRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Booth> GetBooths()
        {
            return _context.Booths;
        }

        public IEnumerable<Booth> GetBoothsByCounter(string counterId)
        {
            return _context.Booths.Where(a => a.CounterId == counterId);
        }

        public int AddBooth(Booth booth)
        {
            _context.Booths.Add(booth);
            return _context.SaveChanges();
        }

        public int UpdateBooth(Booth boothChanges)
        {
            var booth = _context.Booths.Attach(boothChanges);
            booth.State = EntityState.Modified;
            return _context.SaveChanges();
        }

        public int DeleteBooth(string boothId)
        {
            int rowEffected = 0;
            var booth = _context.Booths.Find(boothId);
            if (booth!=null)
            {
                _context.Booths.Remove(booth);
                rowEffected = _context.SaveChanges();
            }

            return rowEffected;
        }
    }
}
