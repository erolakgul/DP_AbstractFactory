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
