using System.Collections.Generic;

namespace BDCounterEtokenSystem.Models.Repositories
{
    public interface ICounterRepository
    {
        IEnumerable<Counter> GetCounters();
        Counter GetCounter(int id);
        Counter GetCounter(string name);
        int Add(Counter counter);
        int Update(Counter counterChanges);
        Counter Delete(int id);
    }
}
