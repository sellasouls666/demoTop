using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.User
{
    public class UserRepository
    {
        private const string connString = "Host=localhost;Username=postgres;Password=123456;Database=shoes_store";

        public List<User> GetUsers()
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("SELECT * FROM users", conn); ;
                var reader = cmd.ExecuteReader();
                List<User> users = new List<User>();

                while (reader.Read())
                {
                    User u = new User();
                    u.Role = reader.GetString(0);
                    u.Fio = reader.GetString(1);
                    u.Login = reader.GetString(2);
                    u.Password = reader.GetString(3);
                    users.Add(u);
                }

                conn.Close();
                return users;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении пользователей: " + ex.Message);
            }

        }
    }
}
