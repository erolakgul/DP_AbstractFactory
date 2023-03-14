using DP_AbstractFactory.Models.Abstract.Command_;
using System;

namespace DP_AbstractFactory.Models.Concrete.Command_
{
    public class InterbaseCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("interbase Sorgusu çalıştırılır");
        }
    }
}
