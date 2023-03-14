using DP_AbstractFactory.Models.Abstract.Command_;
using System;

namespace DP_AbstractFactory.Models.Concrete.Command_
{
    public class Db2Command : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("DB2 Sorgusu çalıştırılır");
        }
    }
}
