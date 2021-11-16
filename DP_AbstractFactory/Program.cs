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
            Factory _factory = new Factory(new InterbaseFactory());
            _factory.Start();

            Factory _factory2 = new Factory(new Db2Factory());
            _factory2.Start();

            Console.ReadKey();
        }
    }

}