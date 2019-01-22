using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using OnlineShoppingStore.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Web.Controllers
{
    public class ProductController : Controller
    {
        public IProductRepository repository;
        public ProductController(IProductRepository productRepository)
        {
            repository = productRepository;
        }
        // GET: Product
        public ActionResult DisplayProducts()
        {
             return View(repository.Products);

        }
        public ActionResult AddUpdateProduct(int productId)
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddUpdateProduct(ProductViewModel product )
        {
            if(ModelState.IsValid)
            {
                Product _product = new Product();
                _product.ProductId = product.ProductId;
                _product.ProductName = product.ProductName;
                _product.CategoryId = 1;
                _product.Description = product.Description;
                _product.ProductImage = product.ProductImage;
                _product.Price = product.Price;
                _product.IsActive = product.IsActive;
                _product.IsDelete = product.IsDelete;

                repository.SaveProduct(_product);
                return Content("True");
            }
            else
            return Content("False");
        }

        [HttpPost]
        public ActionResult DeleteProduct(int productId)
        {
            if(ModelState.IsValid)
            {
                repository.DeleteProduct(productId);
                return Content("True");
            }
            else
                return Content("False");
        }
    }
}