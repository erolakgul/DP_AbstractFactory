using DP_AbstractFactory.Models.Abstract.Connect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Models.Concrete.Connect_
{
    public class Db2Connection : Connection
    {
        public override string State { get { return "Open"; } }

        public override bool Disconnect()
        {
            Console.WriteLine("Db2Baglantisi kapatilacak");
            return true;
        }

        public override bool Connect()
        {
            Console.WriteLine("Db2Baglantisi acilacak");
            return true;
        }
    }
}
