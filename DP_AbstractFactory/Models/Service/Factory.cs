using DP_AbstractFactory.Models.Abstract;
using DP_AbstractFactory.Models.Abstract.Connect_;
using DP_AbstractFactory.Models.Abstract.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory.Models.Service
{
    public class Factory
    {
        private DatabaseFactory _databaseFactory;
        private Connection _connection;
        private Command _command;

        public Factory(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = databaseFactory.CreateConnection();
            _command = _databaseFactory.CreateCommand();
        }

        public void Start()
        {
            _connection.Connect();

            if (_connection.State == "Open")
                _command.Execute("select ...");

            

        }
    }
}
