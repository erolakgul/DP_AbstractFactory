using DP_AbstractFactory.Models.Abstract.Command_;
using DP_AbstractFactory.Models.Abstract.Connect_;
using DP_AbstractFactory.Models.Abstract.Factory;

namespace DP_AbstractFactory.Models.Service
{
    public class FactoryService
    {
        private DatabaseFactory _databaseFactory;
        private Connection _connection;
        private Command _command;

        public FactoryService(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
           // _connection = _databaseFactory.CreateConnection();
           // _command = _databaseFactory.CreateCommand();
        }

        public void Start()
        {
            _connection.Connect();

            if (_connection.State == "Open")
                _command.Execute("select ...");
        }


        public void CreateConnection()
        {
            _connection = _databaseFactory.CreateConnection();
        }

        public void CreateCommand()
        {
            _command = _databaseFactory.CreateCommand();
        }

        public void Stop()
        {
            _connection.Disconnect();
        }

    }
}
