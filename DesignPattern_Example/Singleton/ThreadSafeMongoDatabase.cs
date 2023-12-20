using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Singleton;

public class ThreadSafeMongoDatabase
{
    private static ThreadSafeMongoDatabase instance;
    private static readonly object lockObject = new ();
    private ThreadSafeMongoDatabase() { }
    public static ThreadSafeMongoDatabase GetInstance()
    {
        lock (lockObject)
        {
            if (instance == null)
            {
                instance = new ();
            }
        }
        return instance;
        
    }
}
