using finalDegreeProjectP2.Model;
using Npgsql;
using System.Data;

namespace finalDegreeProjectP2.Service
{
    internal class LoginService
    {
        private readonly DBConn _dbConnection;

        public LoginService()
        {
            _dbConnection = new DBConn();
        }

        public async Task<bool> Authenticate(string username, string password)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                await connection.OpenAsync();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password;";
                    command.Parameters.Add(new NpgsqlParameter("@username", DbType.String) { Value = username });
                    command.Parameters.Add(new NpgsqlParameter("@password", DbType.String) { Value = password });

                    var result = await command.ExecuteScalarAsync();
                    return (long)result > 0;
                }
            }
        }
    }
}
