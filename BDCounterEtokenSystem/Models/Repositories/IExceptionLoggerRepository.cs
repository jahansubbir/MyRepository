using System;
using System.Collections.Generic;

namespace BDCounterEtokenSystem.Models.Repositories
{
  public  interface IExceptionLoggerRepository
  {
      IEnumerable<Exception> GetExceptions();
      Exception Add(Exception exception);



  }
}
