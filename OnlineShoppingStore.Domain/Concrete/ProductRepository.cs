using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly DBContextjqueryMVC context = new DBContextjqueryMVC();
        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products;
            }
        }


        public void SaveProduct(Product product)
        {
            Product _product = new Product();
            if(product.ProductId==0)
            {
                context.Products.Add(product);
                _product.CreatedOn = DateTime.Now;
            }
            else
            {
                _product = context.Products.Find(product.ProductId);
                _product.ModifiedOn = DateTime.Now;
            }
            _product.ProductName = product.ProductName;
            _product.CategoryId = product.CategoryId;
            _product.Description = product.Description;
            _product.ProductImage = product.ProductImage;
            _product.Price = product.Price;
            _product.IsActive = product.IsActive;
            _product.IsDelete = product.IsDelete;

            context.SaveChanges();
        }

        public void DeleteProduct(int ProductId)
        {
            Product product = context.Products.Find(ProductId);
            if(product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
