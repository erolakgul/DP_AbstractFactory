using DP_AbstractFactory.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Models.Concrete.Connect_
{
    public class InterbaseCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("interbase Sorgusu çalıştırılır");
        }
    }
}
