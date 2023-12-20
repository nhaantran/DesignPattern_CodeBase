using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace DesignPattern_Example.Singleton;

public class BillPughMongoDatabase
{
    private BillPughMongoDatabase() { }
    private static class MongoDatabaseSingletonHelper
    {
        public static readonly BillPughMongoDatabase instance = new ();
    }
    public static BillPughMongoDatabase GetInstance()
    {
        return MongoDatabaseSingletonHelper.instance;
    }
}
