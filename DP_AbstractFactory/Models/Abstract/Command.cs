using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Models.Abstract
{
    public abstract class Command
    {
        public abstract void Execute(string query);
    }
}
