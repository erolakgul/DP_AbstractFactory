using DP_AbstractFactory.Models.Abstract.Connect_;
using System;

namespace DP_AbstractFactory.Models.Concrete.Connect_
{
    public class Db2Connection : Connection
    {
        public override string State { get { return "Open"; } }

        public override bool Disconnect()
        {
            Console.WriteLine("Db2 Baglantisi kapatilacak");
            return true;
        }

        public override bool Connect()
        {
            Console.WriteLine("Db2 Baglantisi acilacak");
            return true;
        }
    }
}
