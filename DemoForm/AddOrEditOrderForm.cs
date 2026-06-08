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
    public partial class AddOrEditOrderForm : Form
    {
        private int type_;
        private OrderService orderService_;
        private ProductService productService_;
        private Order order_;
        private List<OrderProducts> orderProducts_;
        private User currentUser_;
        public AddOrEditOrderForm(int type, OrderService orderService, ProductService productService, Order order, User user, List<OrderProducts> orderProducts)
        {
            InitializeComponent();

            type_ = type;
            orderService_ = orderService;
            productService_ = productService;
            currentUser_ = user;
            if (type_ == 0)
            {
                order_ = new Order();
                orderProducts_ = new List<OrderProducts>();
            }
            if (type_ == 1)
            {
                order_ = order;
                orderProducts_ = orderProducts;
            }
        }

        private void AddOrEditOrderForm_Load(object sender, EventArgs e)
        {
            if (type_ == 0)
            {
                this.Text = "Добавление заказа";
            }

            if (type_ == 1)
            {
                this.Text = "Редактирование заказа";
                if (orderProducts_.Count() == 1)
                {
                    articulBox1.Text = orderProducts_.FirstOrDefault<OrderProducts>().Articul;
                    countBox1.Value = orderProducts_.FirstOrDefault<OrderProducts>().Count;
                }
                else
                {
                    articulBox1.Text = orderProducts_.FirstOrDefault<OrderProducts>().Articul;
                    countBox1.Value = orderProducts_.FirstOrDefault<OrderProducts>().Count;
                    articulBox2.Text = orderProducts_.LastOrDefault<OrderProducts>().Articul;
                    countBox2.Value = orderProducts_.LastOrDefault<OrderProducts>().Count;
                }
                statusBox.Text = order_.Status;
                pickupAddressBox.Text = orderService_.GetPickupAddress(order_.IdPickup);
                orderDateBox.Value = order_.OrderDate;
                delieveryDateBox.Value = order_.DelieveryDate;
            }

            pickupAddressBox.DataSource = orderService_.GetPickupsAdresses();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(articulBox1.Text) && string.IsNullOrWhiteSpace(articulBox2.Text))
            {
                MessageBox.Show("Пожалуйста, введите артикул товара");
                return;
            }

            if (!string.IsNullOrWhiteSpace(articulBox1.Text) && countBox1.Value == 0 || !string.IsNullOrWhiteSpace(articulBox2.Text) && countBox2.Value == 0)
            {
                MessageBox.Show("Пожалуйста, укажите количество товара");
                return;
            }

            if (!string.IsNullOrWhiteSpace(articulBox1.Text) && !productService_.CheckArticul(articulBox1.Text) || !string.IsNullOrWhiteSpace(articulBox2.Text) 
                && !productService_.CheckArticul(articulBox2.Text))
            {
                MessageBox.Show("Товара с указанным вами артикулом не существует");
                return;
            }

            if (string.IsNullOrWhiteSpace(statusBox.Text))
            {
                MessageBox.Show("Пожалуйста, укажите статус заказа");
                return;
            }

            if (string.IsNullOrWhiteSpace(pickupAddressBox.Text)) 
            {
                MessageBox.Show("Пожалуйста, укажите адрес пункта выдачи");
                return;
            }

            if (delieveryDateBox.Value < orderDateBox.Value)
            {
                MessageBox.Show("Дата выдачи не может быть раньше даты оформления заказа");
                return;
            }

            if (type_ == 0)
            {
                order_.Id = orderService_.GetOrders().Count + 1;
            }
            order_.OrderDate = orderDateBox.Value;
            order_.DelieveryDate = delieveryDateBox.Value;
            order_.IdPickup = orderService_.GetPickupId(pickupAddressBox.Text);
            order_.Fio = currentUser_.Fio;
            order_.Code = orderService_.GetOrders().LastOrDefault<Order>().Code + 1;
            order_.Status = statusBox.Text;
            order_.UserLogin = currentUser_.Login;

            foreach (OrderProducts op in orderProducts_)
            {
                orderService_.DeleteOrderProducts(op);
            }
            orderProducts_ = new List<OrderProducts>();

            if (!string.IsNullOrWhiteSpace(articulBox1.Text))
            {
                OrderProducts orderProducts = new OrderProducts();
                orderProducts.Id = orderService_.GetOrderProducts().Count + 1;
                orderProducts.OrderId = order_.Id;
                orderProducts.Articul = articulBox1.Text;
                orderProducts.Count = (int)countBox1.Value;
                orderProducts_.Add(orderProducts);
            }

            if (!string.IsNullOrWhiteSpace(articulBox2.Text))
            {
                OrderProducts orderProducts = new OrderProducts();
                orderProducts.Id = orderService_.GetOrderProducts().Count + 1;
                orderProducts.OrderId = order_.Id;
                orderProducts.Articul = articulBox2.Text;
                orderProducts.Count = (int)countBox2.Value;
                orderProducts_.Add(orderProducts);
            }

            this.DialogResult = DialogResult.OK;
        }

        public Order GetOrder()
        {
            return order_;
        }

        public List<OrderProducts> GetOrderProducts()
        {
            return orderProducts_;
        }
    }
}
