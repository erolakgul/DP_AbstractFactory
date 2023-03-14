using DP_AbstractFactory.Models.Abstract.Command_;
using DP_AbstractFactory.Models.Abstract.Connect_;

namespace DP_AbstractFactory.Models.Abstract.Factory
{
    //istemcinin ihtiyacı olan ürünlerin üretilmesi
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}
