using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Order
{
    public class OrderService
    {
        private OrderRepository orderRepository_;

        public OrderService(OrderRepository orderRepository)
        {
            orderRepository_ = orderRepository;
        }

        public bool CheckProductInOrders(DemoLib.Product.Product product)
        {
            List<OrderProducts> orderProducts = orderRepository_.GetOrderProducts();
            foreach (OrderProducts op in orderProducts)
            {
                if (op.Articul == product.Articul)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Order> GetOrders()
        {
            return orderRepository_.GetOrders();
        }

        public List<OrderProducts> GetProductsInOrder(int orderId)
        {
            List<OrderProducts> productsInOrder = new List<OrderProducts>();

            foreach (OrderProducts op in orderRepository_.GetOrderProducts())
            {
                if (op.OrderId == orderId)
                {
                    productsInOrder.Add(op);
                }
            }

            return productsInOrder;
        }

        public string GetPickupAddress(int pickupId)
        {
            List<Pickup> pickups = orderRepository_.GetPickups();
            foreach (Pickup p in pickups)
            {
                if (p.Id == pickupId)
                {
                    return p.Address;
                }
            }
            return null;
        }

        public void AddOrder(Order order)
        {
            orderRepository_.AddOrder(order);
        }

        public void AddOrderProducts(OrderProducts orderProducts)
        {
            orderRepository_.AddOrderProducts(orderProducts);
        }

        public List<string> GetPickupsAdresses()
        {
            List<string> adresses = new List<string>();
            List<Pickup> pickups = orderRepository_.GetPickups();

            foreach (Pickup p in pickups)
            {
                adresses.Add(p.Address);
            }
            return adresses;
        }

        public int GetPickupId(string pickupAddress)
        {
            List<Pickup> pickups = orderRepository_.GetPickups();
            foreach (Pickup p in pickups)
            {
                if (p.Address == pickupAddress)
                {
                    return p.Id;
                }
            }
            return 0;
        }

        public List<OrderProducts> GetOrderProducts()
        {
            return orderRepository_.GetOrderProducts();
        }

        public void EditOrder(Order order)
        {
            orderRepository_.EditOrder(order);
        }

        public void DeleteOrderProducts(OrderProducts orderProducts)
        {
            orderRepository_.DeleteOrderProducts(orderProducts);
        }

        public void DeleteOrder(Order order)
        {
            orderRepository_.DeleteOrder(order);
        }
    }
}
