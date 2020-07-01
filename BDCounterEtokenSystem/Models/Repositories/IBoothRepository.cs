using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDCounterETokenSystem.Models.Repositories
{
    public interface IBoothRepository
    {
        IEnumerable<Booth> GetBooths();
        IEnumerable<Booth> GetBoothsByCounter(string counterId);
        int AddBooth(Booth booth);
        int UpdateBooth(Booth boothChanges);
        int DeleteBooth(string boothId);
    }
}
