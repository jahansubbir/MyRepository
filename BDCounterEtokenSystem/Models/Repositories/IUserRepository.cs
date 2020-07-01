using System.Collections.Generic;

namespace BDCounterEtokenSystem.Models.Repositories
{
    public interface IUserRepository
    {
        User GetUser(string uId);
        IEnumerable<User> GetUsers();
        User Add(User user);
        User Update(User userChanges);
        User Delete(string uId);



    }
}
