using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Product
{
    public class ProductService
    {
        private ProductRepository productRepository_;

        public ProductService(ProductRepository productRepository)
        {
            productRepository_ = productRepository;
        }

        public List<Product> GetProducts()
        {
            return productRepository_.GetProducts();
        }

        public void AddProduct(Product product)
        {
            productRepository_.AddProduct(product);
        }

        public void EditProduct(Product product)
        {
            productRepository_.EditProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            productRepository_.DeleteProduct(product);
        }

        public bool CheckArticul(string articul)
        {
            List<Product> products = productRepository_.GetProducts();
            foreach (Product product in products)
            {
                if (product.Articul == articul)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
