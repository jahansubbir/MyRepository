using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BDCounterEtokenSystem.Models.Repositories
{
    public class CounterRepository : ICounterRepository
    {
        private readonly AppDbContext _context;


        public CounterRepository(AppDbContext context)
        {
            _context = context;

        }
        public IEnumerable<Counter> GetCounters()
        {
            return _context.Counters;
        }

        public Counter GetCounter(int id)
        {
            //throw new NotImplementedException();
            return _context.Counters.Find(id);
        }

        public Counter GetCounter(string name)
        {
            return _context.Counters.FirstOrDefault(c => c.Name.Equals(name));
        }

        public int Add(Counter counter)
        {
            int rowAdded = 0;
            var existingCounter = GetCounter(counter.Name);
            if (existingCounter == null)
            {
                try
                {

                    _context.Counters.Add(counter);
                    rowAdded = _context.SaveChanges();

                }
                catch (DbUpdateException dbUpdateException)
                {
                    ExceptionLogger.Log(dbUpdateException);
                }

            }

            return rowAdded;

        }




        public int Update(Counter counterChanges)
        {
            int i = 0;
            try
            {


                var counter = _context.Counters.Attach(counterChanges);
                counter.State = EntityState.Modified;
                i = _context.SaveChanges();
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return i;
        }

        public Counter Delete(int id)
        {
            Counter counter = null;
            try
            {
                counter = _context.Counters.Find(id);
                if (counter != null)
                {
                    _context.Counters.Remove(counter);
                    _context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                ExceptionLogger.Log(e);
            }

            return counter;
        }
    }
}
