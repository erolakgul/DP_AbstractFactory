using DP_AbstractFactory.Models.Abstract.Connect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Models.Abstract.Factory
{
    //istemcinin ihtiyacı olan ürünlerin üretilmesi
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
