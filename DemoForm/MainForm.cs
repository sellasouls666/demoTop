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
using DemoLib.Product;
using DemoLib.User;

namespace DemoForm
{
    public partial class MainForm : Form
    {
        private ProductService productService_;
        private List<Product> products_;
        private User currentUser_;
        private OrderService orderService_;
        public MainForm(User user)
        {
            InitializeComponent();

            ProductRepository productRepository = new ProductRepository();
            productService_ = new ProductService(productRepository);

            products_ = productService_.GetProducts();

            currentUser_ = user;

            OrderRepository orderRepository = new OrderRepository();
            orderService_ = new OrderService(orderRepository);
        }

        private void ShowProducts(List<Product> products)
        {
            productsNameList.DataSource = null;
            productsNameList.DataSource = products;
            productsNameList.DisplayMember = "Articul";
        }

        private void productsNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = productsNameList.SelectedItem;
            if (selectedItem != null)
            {
                Product product = selectedItem as Product;
                if (product != null)
                {
                    productCard.ShowProductInfo(product);
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            SearchAndFilter(searchBox.Text.ToLower());
        }

        private void SearchAndFilter(string search)
        {
            List<Product> searchedProducts = new List<Product>();

            if (search != null)
            {
                foreach (Product p in products_)
                {
                    if (p.Articul.ToLower().Contains(search) ||
                        p.Name.ToLower().Contains(search) ||
                        p.Supplier.ToLower().Contains(search) ||
                        p.Manufacturer.ToLower().Contains(search) ||
                        p.Category.ToLower().Contains(search) ||
                        p.Description.ToLower().Contains(search))
                    {
                        searchedProducts.Add(p);
                    }
                }
            }
            if (search == null)
            {
                searchedProducts = products_;
            }

            List<Product> searchedAndFilteredProducts = new List<Product>();
            if (filtrBox.Text == "Все поставщики")
            {
                searchedAndFilteredProducts = searchedProducts;
            }
            else
            {
                foreach (Product p in searchedProducts)
                {
                    if (p.Supplier == filtrBox.Text)
                    {
                        searchedAndFilteredProducts.Add(p);
                    }
                }
            }

            ShowProducts(searchedAndFilteredProducts);
        }

        private void CheckRole()
        {
           if (currentUser_ != null)
            {
                if (currentUser_.Role == "Администратор")
                {
                    addButton.Enabled = true;
                    deleteButton.Enabled = true;
                }
                else
                {
                    addButton.Enabled = false;
                    deleteButton.Enabled = false;
                }
                if (currentUser_.Role == "Менеджер" || currentUser_.Role == "Администратор")
                {
                    searchBox.Enabled = true;
                    upScaleCountButton.Enabled = true;
                    downScaleCountButton.Enabled = true;
                    filtrBox.Enabled = true;
                    ordersButton.Enabled = true;
                }
                else
                {
                    searchBox.Enabled = false;
                    upScaleCountButton.Enabled = false;
                    downScaleCountButton.Enabled = false;
                    filtrBox.Enabled = false;
                    ordersButton.Enabled = false;
                }
            }
            else
            {
                searchBox.Enabled = false;
                upScaleCountButton.Enabled = false;
                downScaleCountButton.Enabled = false;
                filtrBox.Enabled = false;
                addButton.Enabled = false;
                deleteButton.Enabled = false;
                ordersButton.Enabled = false;
            }
        }

        private void upScaleCountButton_Click(object sender, EventArgs e)
        {
            products_ = products_.OrderBy(p  => p.Count).ToList();
            SearchAndFilter(searchBox.Text);
        }

        private void downScaleCountButton_Click(object sender, EventArgs e)
        {
            products_ = products_.OrderByDescending(p => p.Count).ToList();
            SearchAndFilter(searchBox.Text);
        }

        private void filtrBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAndFilter(searchBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEditForm addForm = new AddOrEditForm(0, null, productService_);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                productService_.AddProduct(addForm.GetProduct());
                MessageBox.Show("Товар добавлен успешно");
                products_ = productService_.GetProducts();
                SearchAndFilter(searchBox.Text);
            }
        }

        private void productCard_DoubleClick(object sender, EventArgs e)
        {
            if (currentUser_ != null && currentUser_.Role == "Администратор")
            {
                var selectedItem = productsNameList.SelectedItem;
                Product editProduct = selectedItem as Product;
                AddOrEditForm editForm = new AddOrEditForm(1, editProduct, productService_);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    productService_.EditProduct(editForm.GetProduct());
                    MessageBox.Show("Товар успешно отредактирован");
                    products_ = productService_.GetProducts();
                    SearchAndFilter(searchBox.Text);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowProducts(products_);

            if (currentUser_ != null)
            {
                fioLabel.Text = currentUser_.Fio;
            }
            else
            {
                fioLabel.Text = "Гость";
            }

            iconBox.Load("Icon.png");

            CheckRole();

            List<string> suppliers = new List<string>();
            suppliers.Add("Все поставщики");
            foreach (Product p in products_)
            {
                if (!suppliers.Contains(p.Supplier))
                {
                    suppliers.Add(p.Supplier);
                }
            }
            filtrBox.DataSource = suppliers;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedItem = productsNameList.SelectedItem;
            Product product = selectedItem as Product;
            if (orderService_.CheckProductInOrders(product))
            {
                MessageBox.Show("Вы не можете удалить данный товар, так как он присутствует в заказе");
                return;
            }
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить товар " + product.Articul + "?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                productService_ .DeleteProduct(product);
                MessageBox.Show("Товар успешно удалён");
                products_ = productService_.GetProducts();
                SearchAndFilter(searchBox.Text);
            }
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm(orderService_, productService_, currentUser_);
            ordersForm.Show();
        }
    }
}
