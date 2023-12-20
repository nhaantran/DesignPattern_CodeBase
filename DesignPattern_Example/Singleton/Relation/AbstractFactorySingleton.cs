//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPattern_Example.Singleton.Relation;

//public interface IProductA { };
//public interface IProductB { };
//public interface IAbstractFactory
//{
//    IProductA CreateProductA();
//    IProductB CreateProductB();
//}

//public class ConcreteFactory : IAbstractFactory
//{
//    private static ConcreteFactory instance;

//    private ConcreteFactory() { }

//    public static ConcreteFactory Instance
//    {
//        get
//        {
//            if (instance == null)
//            {
//                instance = new ConcreteFactory();
//            }
//            return instance;
//        }
//    }

//    //public IProductA CreateProductA()
//    //{
//    //    return new ConcreteProductA();
//    //}

//    //public IProductB CreateProductB()
//    //{
//    //    return new ConcreteProductB();
//    //}
//}



