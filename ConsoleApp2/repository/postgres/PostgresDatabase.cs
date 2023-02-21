using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using It_PlanetaApi.config;
using Npgsql;

namespace repository.postgres
{
    public class PostgresDatabase
    {
        private NpgsqlConnection _connection;
        public PostgresDatabase(Config config)
        {

            var connectionString = config.GetDataBaseConnString();
            Connect(connectionString);

        }

        public NpgsqlConnection getConnection()
        {
            if (_connection == null)
            {
                throw new NullReferenceException("connection not initialized");
            }
            return _connection;
        }
        private void Connect(string connectionString)
        {
            _connection = new NpgsqlConnection(connectionString);
            _connection.Open();
        }
    }
}
