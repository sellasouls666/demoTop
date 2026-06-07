using DemoLib.Product;
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
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();

            this.categoryLabel.DoubleClick += ChildControl_DoubleClick;
            this.countLabel.DoubleClick += ChildControl_DoubleClick;
            this.descriptionLabel.DoubleClick += ChildControl_DoubleClick;
            this.discountLabel.DoubleClick += ChildControl_DoubleClick;
            this.label1.DoubleClick += ChildControl_DoubleClick;
            this.manufacturerLabel.DoubleClick += ChildControl_DoubleClick;
            this.nameLabel.DoubleClick += ChildControl_DoubleClick;
            this.newPriceLabel.DoubleClick += ChildControl_DoubleClick;
            this.picBox.DoubleClick += ChildControl_DoubleClick;
            this.priceLabel.DoubleClick += ChildControl_DoubleClick;
            this.supplierLabel.DoubleClick += ChildControl_DoubleClick;
            this.unitLabel.DoubleClick += ChildControl_DoubleClick;
        }

        public void ShowProductInfo(Product product)
        {
            if (!string.IsNullOrWhiteSpace(product.Pic))
            {
                picBox.Load(product.Pic);
            }
            else
            {
                picBox.Load("picture.png");
            }

            categoryLabel.Text = product.Category;
            nameLabel.Text = product.Name;
            descriptionLabel.Text = "Описание товара: " + product.Description;
            manufacturerLabel.Text = "Производитель: " + product.Manufacturer;
            supplierLabel.Text = "Поставщик: " + product.Supplier;
            priceLabel.Text = product.Price.ToString();
            unitLabel.Text = "Единица измерения: " + product.Unit;
            countLabel.Text = "Количество на складе: " + product.Count.ToString();
            discountLabel.Text = product.Discount.ToString();

            if (product.Discount > 15)
            {
                this.BackColor = Color.SeaGreen;
            }
            else
            {
                this.BackColor = Color.Chartreuse;
            }

            if (product.Discount != 0)
            {
                priceLabel.ForeColor = Color.Red;
                priceLabel.Font = new Font(priceLabel.Font, FontStyle.Strikeout);
                newPriceLabel.Text = (product.Price - (product.Price / 100 * product.Discount)).ToString();
            }
            else
            {
                priceLabel.ForeColor = Color.Black;
                priceLabel.Font = new Font(priceLabel.Font, FontStyle.Regular);
                newPriceLabel.Text = "";
            }

            if (product.Count == 0)
            {
                countLabel.BackColor = Color.Blue;
            }
            else
            {
                if (product.Discount > 15)
                {
                    countLabel.BackColor = Color.SeaGreen;
                }
                else
                {
                    countLabel.BackColor = Color.Chartreuse;
                }
            }
        }

        private void ChildControl_DoubleClick(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }
    }
}
