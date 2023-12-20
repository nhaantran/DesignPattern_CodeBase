using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Singleton
{
    public class DoubleCheckThreadSafeMongoDatabase
    {
        private static DoubleCheckThreadSafeMongoDatabase instance;
        private static readonly object lockObject = new ();
        private DoubleCheckThreadSafeMongoDatabase() { }
        public static DoubleCheckThreadSafeMongoDatabase GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ();
                    }
                }
            }
            return instance;
        }
    }
}
