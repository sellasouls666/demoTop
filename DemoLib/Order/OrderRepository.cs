using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Order
{
    public class OrderRepository
    {
        private const string connString = "Host=localhost;Username=postgres;Password=123456;Database=shoes_store";

        public List<OrderProducts> GetOrderProducts()
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("SELECT * FROM \"orderProducts\"", conn); ;
                var reader = cmd.ExecuteReader();
                List<OrderProducts> orderProducts = new List<OrderProducts>();

                while (reader.Read())
                {
                    OrderProducts op = new OrderProducts();
                    op.Id = reader.GetInt32(0);
                    op.OrderId = reader.GetInt32(1);
                    op.Articul = reader.GetString(2);
                    op.Count = reader.GetInt32(3);
                    orderProducts.Add(op);
                }

                conn.Close();
                return orderProducts;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении товаров: " + ex.Message);
            }

        }
    }
}
