using DemoLib.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class AddOrEditForm : Form
    {
        private Product product_;
        private int type_;
        private string selectedImagePath_ = "picture.png";
        private ProductService productService_;
        public AddOrEditForm(int type, Product editProduct, ProductService productService)
        {
            InitializeComponent();
            type_ = type;
            if (type_ == 0)
            {
                product_ = new Product();
            }
            if (type_ == 1)
            {
                product_ = editProduct;
            }

            productService_ = productService;
        }

        private void picLoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                openFileDialog.Title = "Выберите изображение для товара";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sourcePath = openFileDialog.FileName;

                        string fileName = Path.GetFileName(sourcePath);

                        string targetPath = Path.Combine(Application.StartupPath, fileName);

                        File.Copy(sourcePath, targetPath, true);

                        selectedImagePath_ = fileName;

                        picBox.Image?.Dispose();
                        picBox.Image = Image.FromFile(targetPath);
                        picBox.SizeMode = PictureBoxSizeMode.Zoom;

                        MessageBox.Show("Изображение успешно загружено!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddOrEditForm_Load(object sender, EventArgs e)
        {
            if (type_ == 0)
            {
                this.Text = "Добавление товара";
            }
            if (type_ == 1)
            {
                this.Text = "Редактирование товара";
                if (!string.IsNullOrWhiteSpace(product_.Pic))
                {
                    selectedImagePath_ = product_.Pic;
                }
                articulBox.Text = product_.Articul;
                articulBox.Enabled = false;
                nameBox.Text = product_.Name;
                categoryBox.Text = product_.Category;
                descriptionBox.Text = product_.Description;
                manufacturerBox.Text = product_.Manufacturer;
                supplierBox.Text = product_.Supplier;
                priceBox.Value = (decimal)product_.Price;
                unitBox.Text = product_.Unit;
                countBox.Value = (decimal)product_.Count;
                discountBox.Value = (decimal)product_.Discount;
            }
            picBox.Load(selectedImagePath_);

            List<string> manufacturers = new List<string>();
            foreach (Product product in productService_.GetProducts())
            {
                if (!manufacturers.Contains(product.Manufacturer))
                {
                    manufacturers.Add(product.Manufacturer);
                }
            }
            manufacturerBox.DataSource = manufacturers;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(articulBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите артикул");
                return;
            }

            if (type_ == 0 && CheckArticul(articulBox.Text))
            {
                MessageBox.Show("Уже имеется товар с указанным артикулом");
                return;
            }

            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите наименование");
                return;
            }

            if (string.IsNullOrWhiteSpace(categoryBox.Text))
            {
                MessageBox.Show("Пожалуйста, выберите категорию");
                return;
            }

            if (string.IsNullOrWhiteSpace(descriptionBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите описание");
                return;
            }

            if (string.IsNullOrWhiteSpace(manufacturerBox.Text))
            {
                MessageBox.Show("Пожалуйста, выберите производителя");
                return;
            }

            if (string.IsNullOrWhiteSpace(supplierBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите поставщика");
                return;
            }

            if (string.IsNullOrWhiteSpace(unitBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите единицу измерения");
                return;
            }

            product_.Articul = articulBox.Text;
            product_.Name = nameBox.Text;
            product_.Category = categoryBox.Text;
            product_.Description = descriptionBox.Text;
            product_.Manufacturer = manufacturerBox.Text;
            product_.Supplier = supplierBox.Text;
            product_.Price = (double)priceBox.Value;
            product_.Unit = unitBox.Text;
            product_.Count = (int)countBox.Value;
            product_.Discount = (int)discountBox.Value;
            product_.Pic = selectedImagePath_;

            this.DialogResult = DialogResult.OK;
        }

        private bool CheckArticul(string articul)
        {
            foreach (Product product in productService_.GetProducts())
            {
                if (product.Articul == articul)
                {
                    return true;
                }
            }
            return false;
        }

        public Product GetProduct()
        {
            return product_;
        }
    }
}
