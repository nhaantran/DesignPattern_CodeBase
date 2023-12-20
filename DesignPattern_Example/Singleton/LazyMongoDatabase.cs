using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Singleton;

public class LazyMongoDatabase
{
    private static LazyMongoDatabase instance;
    private LazyMongoDatabase() { }
    public static LazyMongoDatabase GetInstance()
    {
        // instance sẽ được khởi tạo nếu chưa được khởi tạo
        if (instance == null)
        {
            instance = new LazyMongoDatabase();
        }
        return instance;
    }
}
