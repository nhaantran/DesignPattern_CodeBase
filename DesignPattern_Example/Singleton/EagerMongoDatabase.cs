using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Singleton;


public class EagerMongoDatabase
{
    // instance sẽ được khởi tạo khi chương trình start up
    private static readonly EagerMongoDatabase instance = new();
    private EagerMongoDatabase() { }
    public static EagerMongoDatabase GetInstance()
    {
        return instance;
    }
}
