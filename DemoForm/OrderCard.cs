using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLib.Order;

namespace DemoForm
{
    public partial class OrderCard : UserControl
    {
        public OrderCard()
        {
            InitializeComponent();

            this.articulLabel.DoubleClick += ChildControl_DoubleClick;
            this.delieveryDateLabel.DoubleClick += ChildControl_DoubleClick;
            this.orderDateLabel.DoubleClick += ChildControl_DoubleClick;
            this.pickupAddressLabel.DoubleClick += ChildControl_DoubleClick;
            this.statusLabel.DoubleClick += ChildControl_DoubleClick;
        }

        public void ShowOrder(string articul, Order order, string pickupAddress)
        {
            articulLabel.Text = "Артикул заказа: " + articul;
            statusLabel.Text = "Статус заказа: " + order.Status;
            pickupAddressLabel.Text = "Адрес пункта выдачи: " + pickupAddress;
            orderDateLabel.Text = "Дата заказа: " + order.OrderDate.ToShortDateString();
            delieveryDateLabel.Text = order.DelieveryDate.ToShortDateString();
        }

        private void ChildControl_DoubleClick(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }
    }
}
