using DP_AbstractFactory.Models.Abstract.Factory;
using DP_AbstractFactory.Models.Concrete.Factory;
using DP_AbstractFactory.Models.Service;
using System;

namespace DP_AbstractFactory
{
    class Program
    {
        #region NOT
        //Factory Method D.P.; ilişkisel olan birden fazla nesnenin üretimini ortak bir ara yüz aracılığıyla tek bir sınıf üzerinden yapılacak bir talep ile gerçekleştirmek ve nesne üretim anında istemcinin üretilen nesneye olan bağımlılığını sıfıra indirmeyi hedeflemektedir.
        //Absact Factory D.P.ise ilişkisel olan birden fazla nesnenin üretimini tek bir ara yüz tarafından değil her ürün ailesi için farklı bir arayüz tanımlayarak sağlamaktadır.
        //Yani anlayacağınız birden fazla ürün ailesi ile çalışmak zorunda kaldığımız durumlarda, istemciyi bu yapılardan soyutlamak için Abstract Factory D.P.doğru bir yaklaşım olacaktır. 
        #endregion
      
        static void Main(string[] args)
        {
            //Abstract Factory is a creational design pattern,
            //which solves the problem of creating entire product families without specifying their concrete classes.
            FactoryService _factory = new FactoryService(new InterbaseFactory());
            _factory.CreateConnection();
            _factory.CreateCommand();
            _factory.Start();
            _factory.Stop();

            Console.WriteLine();



            FactoryService _factory2 = new FactoryService(new Db2Factory());
            _factory2.CreateConnection();
            _factory2.CreateCommand();
            _factory2.Start();
            _factory2.Stop();

            Console.ReadKey();
        }
    }

}