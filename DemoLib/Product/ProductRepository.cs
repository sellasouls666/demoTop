using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Product
{
    public class ProductRepository
    {
        private const string connString = "Host=localhost;Username=postgres;Password=123456;Database=shoes_store";

        public List<Product> GetProducts()
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("SELECT * FROM products", conn); ;
                var reader = cmd.ExecuteReader();
                List<Product> products = new List<Product>();

                while (reader.Read())
                {
                    Product p = new Product();
                    p.Articul = reader.GetString(0);
                    p.Name = reader.GetString(1);
                    p.Unit = reader.GetString(2);
                    p.Price = reader.GetDouble(3);
                    p.Supplier = reader.GetString(4);
                    p.Manufacturer = reader.GetString(5);
                    p.Category = reader.GetString(6);
                    p.Discount = reader.GetInt32(7);
                    p.Count = reader.GetInt32(8);
                    p.Description = reader.GetString(9);
                    p.Pic = reader.IsDBNull(10) ? null : reader.GetString(10);
                    products.Add(p);
                }

                conn.Close();
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при чтении товаров: " + ex.Message);
            }

        }

        public void AddProduct(Product product)
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("INSERT INTO products (articul, name, unit, price, supplier, manufacturer, category, discount, count, description, pic) VALUES (@articul, @name, " +
                    "@unit, @price, @supplier, @manufacturer, @category, @discount, @count, @description, @pic)", conn);
                cmd.Parameters.AddWithValue("articul", product.Articul);
                cmd.Parameters.AddWithValue("name", product.Name);
                cmd.Parameters.AddWithValue("unit", product.Unit);
                cmd.Parameters.AddWithValue("price", product.Price);
                cmd.Parameters.AddWithValue("supplier", product.Supplier);
                cmd.Parameters.AddWithValue("manufacturer", product.Manufacturer);
                cmd.Parameters.AddWithValue("category", product.Category);
                cmd.Parameters.AddWithValue("discount", product.Discount);
                cmd.Parameters.AddWithValue("count", product.Count);
                cmd.Parameters.AddWithValue("description", product.Description);
                cmd.Parameters.AddWithValue("pic", product.Pic);
                cmd.ExecuteNonQuery();

                conn.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Ошибка при добавлении товара: " + ex.Message);
            }
        }

        public void EditProduct(Product product)
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("UPDATE products SET name = @name, unit = @unit, price = @price, supplier = @supplier, manufacturer = @manufacturer, category = @category," +
                    " discount = @discount, count = @count, description = @description, pic = @pic WHERE articul = @articul", conn);
                cmd.Parameters.AddWithValue("articul", product.Articul);
                cmd.Parameters.AddWithValue("name", product.Name);
                cmd.Parameters.AddWithValue("unit", product.Unit);
                cmd.Parameters.AddWithValue("price", product.Price);
                cmd.Parameters.AddWithValue("supplier", product.Supplier);
                cmd.Parameters.AddWithValue("manufacturer", product.Manufacturer);
                cmd.Parameters.AddWithValue("category", product.Category);
                cmd.Parameters.AddWithValue("discount", product.Discount);
                cmd.Parameters.AddWithValue("count", product.Count);
                cmd.Parameters.AddWithValue("description", product.Description);
                cmd.Parameters.AddWithValue("pic", product.Pic);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при редактировании товара: " + ex.Message);
            }
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                var conn = new NpgsqlConnection(connString);
                conn.Open();

                var cmd = new NpgsqlCommand("DELETE FROM products WHERE articul = @articul", conn);
                cmd.Parameters.AddWithValue("articul", product.Articul);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при удалении товара: " + ex.Message);
            }
        }
    }
}
