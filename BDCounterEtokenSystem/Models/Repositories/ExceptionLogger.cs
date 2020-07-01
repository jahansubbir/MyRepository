using System;

namespace BDCounterEtokenSystem.Models.Repositories
{
    public class ExceptionLogger
    {

        private ExceptionLogger()
        {

        }

        private static ExceptionLogger _instance;
        private static readonly object obj = new object();
        public static ExceptionLogger GetInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new ExceptionLogger();
                    }
                }
            }

            return _instance;
        }
        public static void Log(Exception dbUpdateException)
        {
            Console.WriteLine(dbUpdateException.Message+"\t"+DateTime.Now.ToLongTimeString());
            Console.WriteLine(dbUpdateException.StackTrace + "\t" + DateTime.Now.ToLongTimeString());
        }
    }
}
