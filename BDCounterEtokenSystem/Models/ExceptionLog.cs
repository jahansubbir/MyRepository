using System;

namespace BDCounterEtokenSystem.Models
{
    public class ExceptionLog
    {
        public int Id { get; set; }
        public Exception Exception { get; set; }
        public string Message { get; set; }
    }
}
