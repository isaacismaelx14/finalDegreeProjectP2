using Npgsql;
using System.Configuration;

namespace finalDegreeProjectP2.Model
{
    internal class DBConn
    {
        public NpgsqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.AppSettings["ConnectionString"];
            return new NpgsqlConnection(connStr);
        }

        public void ExecuteNonQuery(string query)
        {
            using var connection = GetConnection();
            connection.Open();
            using var command = new NpgsqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public object ExecuteScalar(string query)
        {
            using var connection = GetConnection();
            connection.Open();
            using var command = new NpgsqlCommand(query, connection);
            return command.ExecuteScalar();
        }
    }
}
