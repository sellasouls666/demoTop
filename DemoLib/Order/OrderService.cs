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
    }
}
