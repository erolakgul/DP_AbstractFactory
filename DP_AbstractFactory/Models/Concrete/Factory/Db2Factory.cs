using DP_AbstractFactory.Models.Abstract;
using DP_AbstractFactory.Models.Abstract.Connect_;
using DP_AbstractFactory.Models.Abstract.Factory;
using DP_AbstractFactory.Models.Concrete.Connect_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Models.Concrete.Factory
{
    public class Db2Factory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new Db2Command();
        }

        public override Connection CreateConnection()
        {
            return new Db2Connection();
        }
    }
}
