using DemoLib.Product;
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
                throw new Exception("Ошибка при чтении товаров в заказах: " + ex.Message);
            }

        }

        public List<Order> GetOrders()
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("SELECT * FROM orders", conn); ;
                var reader = cmd.ExecuteReader();
                List<Order> orders = new List<Order>();

                while (reader.Read())
                {
                    Order o = new Order();
                    o.Id = reader.GetInt32(0);
                    o.OrderDate = reader.GetDateTime(1);
                    o.DelieveryDate = reader.GetDateTime(2);
                    o.IdPickup = reader.GetInt32(3);
                    o.Fio = reader.GetString(4);
                    o.Code = reader.GetInt32(5);
                    o.Status = reader.GetString(6);
                    o.UserLogin = reader.GetString(7);
                    orders.Add(o);
                }

                conn.Close();
                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении заказов: " + ex.Message);
            }
        }

        public List<Pickup> GetPickups()
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("SELECT * FROM pickups", conn); ;
                var reader = cmd.ExecuteReader();
                List<Pickup> pickups = new List<Pickup>();

                while (reader.Read())
                {
                    Pickup p = new Pickup();
                    p.Address = reader.GetString(0);
                    p.Id = reader.GetInt32(1);
                    pickups.Add(p);
                }

                conn.Close();
                return pickups;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении пунктов выдачи: " + ex.Message);
            }
        }

        public void AddOrder(Order order)
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("INSERT INTO orders (id, \"orderDate\", \"deliveryDate\", \"idPickup\", fio, code, status, \"userLogin\") VALUES (@id, @orderDate, " +
                    "@delieveryDate, @idPickup, @fio, @code, @status, @userLogin)", conn);
                cmd.Parameters.AddWithValue("id", order.Id);
                cmd.Parameters.AddWithValue("orderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("delieveryDate", order.DelieveryDate);
                cmd.Parameters.AddWithValue("idPickup", order.IdPickup);
                cmd.Parameters.AddWithValue("fio", order.Fio);
                cmd.Parameters.AddWithValue("code", order.Code);
                cmd.Parameters.AddWithValue("status", order.Status);
                cmd.Parameters.AddWithValue("userLogin", order.UserLogin);
                cmd.ExecuteNonQuery();

                conn.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Ошибка при добавлении заказа: " + ex.Message);
            }
        }

        public void AddOrderProducts(OrderProducts orderProducts)
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("INSERT INTO \"orderProducts\" (id, \"orderId\", articul, count) VALUES (@id, @orderId, @articul, @count)", conn);
                cmd.Parameters.AddWithValue("id", orderProducts.Id);
                cmd.Parameters.AddWithValue("orderId", orderProducts.OrderId);
                cmd.Parameters.AddWithValue("articul", orderProducts.Articul);
                cmd.Parameters.AddWithValue("count", orderProducts.Count);
                cmd.ExecuteNonQuery();

                conn.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Ошибка при добавлении товаров заказа: " + ex.Message);
            }
        }

        public void EditOrder(Order order)
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("UPDATE orders SET \"orderDate\" = @orderDate, \"deliveryDate\" = @deliveryDate, \"idPickup\" = @idPickup, fio = @fio, code = @code, " +
                    "status = @status, \"userLogin\" = @userLogin WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("id", order.Id);
                cmd.Parameters.AddWithValue("orderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("deliveryDate", order.DelieveryDate);
                cmd.Parameters.AddWithValue("idPickup", order.IdPickup);
                cmd.Parameters.AddWithValue("fio", order.Fio);
                cmd.Parameters.AddWithValue("code", order.Code);
                cmd.Parameters.AddWithValue("status", order.Status);
                cmd.Parameters.AddWithValue("userLogin", order.UserLogin);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при редактировании заказа: " + ex.Message);
            }
        }

        public void DeleteOrderProducts(OrderProducts orderProducts)
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("DELETE FROM \"orderProducts\" WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("id", orderProducts.Id);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при удалении товаров в заказе: " + ex.Message);
            }
        }

        public void DeleteOrder(Order order)
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("DELETE FROM orders WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("id", order.Id);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при удалении заказа: " + ex.Message);
            }
        }
    }
}
