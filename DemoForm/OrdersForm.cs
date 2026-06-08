using DemoLib.Order;
using DemoLib.Product;
using DemoLib.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class OrdersForm : Form
    {
        private OrderService orderService_;
        private List<Order> orders_;
        private ProductService productService_;
        private User currentUser_;
        public OrdersForm(OrderService orderService, ProductService productService, User user)
        {
            InitializeComponent();

            orderService_ = orderService;
            orders_ = orderService_.GetOrders();
            productService_ = productService;
            currentUser_ = user;
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            ShowOrdersIds(orders_);
            CheckRole();
        }

        private void ShowOrdersIds(List<Order> orders)
        {
            ordersIdsBox.DataSource = null;
            ordersIdsBox.DataSource = orders;
            ordersIdsBox.DisplayMember = "Id";
        }

        private void ordersIdsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersIdsBox.SelectedItem != null)
            {
                Order selectedOrder = ordersIdsBox.SelectedItem as Order;
                if (selectedOrder != null)
                {
                    string articul = null;
                    foreach (OrderProducts op in orderService_.GetProductsInOrder(selectedOrder.Id))
                    {
                        articul += op.Articul + " " + op.Count + " ";
                    }

                    string pickupAddress = orderService_.GetPickupAddress(selectedOrder.IdPickup);
                    orderCard.ShowOrder(articul, selectedOrder, pickupAddress);
                }
            }
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            AddOrEditOrderForm addForm = new AddOrEditOrderForm(0, orderService_, productService_, null, currentUser_, null);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                orderService_.AddOrder(addForm.GetOrder());
                foreach (OrderProducts op in addForm.GetOrderProducts())
                {
                    orderService_.AddOrderProducts(op);
                }
                MessageBox.Show("Заказ успешно добавлен");
                orders_ = orderService_.GetOrders();
                ShowOrdersIds(orders_);
            }
        }

        private void CheckRole()
        {
            if (currentUser_.Role == "Администратор")
            {
                addOrderButton.Enabled = true;
                deleteOrderButton.Enabled = true;
            }
            else
            {
                addOrderButton.Enabled = false;
                deleteOrderButton.Enabled = false;
            }
        }

        private void orderCard_DoubleClick(object sender, EventArgs e)
        {
            if (currentUser_.Role == "Администратор")
            {
                if (ordersIdsBox.SelectedItem != null)
                {
                    Order order = ordersIdsBox.SelectedItem as Order;
                    if (order != null)
                    {
                        List<OrderProducts> orderProducts = orderService_.GetProductsInOrder(order.Id);
                        AddOrEditOrderForm editForm = new AddOrEditOrderForm(1, orderService_, productService_, order, currentUser_, orderProducts);
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            orderService_.EditOrder(editForm.GetOrder());
                            foreach (OrderProducts op in editForm.GetOrderProducts())
                            {
                                orderService_.AddOrderProducts(op);
                            }
                            MessageBox.Show("Заказ успешно отредактирован");
                            orders_ = orderService_.GetOrders();
                            ShowOrdersIds(orders_);
                        }
                    }
                }
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            if (ordersIdsBox.SelectedItem != null)
            {
                Order order = ordersIdsBox.SelectedItem as Order;
                if (order != null)
                {
                    DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить  заказ " + order.Id + "?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        List<OrderProducts> orderProducts = orderService_.GetProductsInOrder(order.Id);
                        foreach (OrderProducts op in orderProducts)
                        {
                            orderService_.DeleteOrderProducts(op);
                        }
                        orderService_.DeleteOrder(order);
                        MessageBox.Show("Удаление выполнено успешно");
                        orders_ = orderService_.GetOrders();
                        ShowOrdersIds(orders_);
                    }
                }
            }
        }
    }
}
