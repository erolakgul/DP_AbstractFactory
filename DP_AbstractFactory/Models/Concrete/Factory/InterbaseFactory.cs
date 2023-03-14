using DP_AbstractFactory.Models.Abstract.Command_;
using DP_AbstractFactory.Models.Abstract.Connect_;
using DP_AbstractFactory.Models.Abstract.Factory;
using DP_AbstractFactory.Models.Concrete.Command_;
using DP_AbstractFactory.Models.Concrete.Connect_;

namespace DP_AbstractFactory.Models.Concrete.Factory
{
    public class InterbaseFactory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new InterbaseCommand();
        }

        public override Connection CreateConnection()
        {
            return new InterbaseConnection();
        }
    }
}
