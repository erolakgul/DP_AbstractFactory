using DP_AbstractFactory.Models.Abstract.Connect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Models.Concrete.Connect_
{
    public class InterbaseConnection : Connection
    {
        public override string State { get { return "Open"; } }

        public override bool Disconnect()
        {
            Console.WriteLine("interbase kapatilacak");
            return true;
        }

        public override bool Connect()
        {
            Console.WriteLine("interbase acilacak");
            return true;
        }

    }
}
