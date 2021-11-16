using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Models.Abstract.Connect_
{
    //Connection ürünleri için soyut tasarım
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool Disconnect();
        public abstract string State { get; } //read-only
    }
}
