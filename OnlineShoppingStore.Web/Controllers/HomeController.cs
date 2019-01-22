using OnlineShoppingStore.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Web.Controllers
{
    public class HomeController : Controller
    {
        ProductRepository repository;
        public HomeController(ProductRepository productRepository)
        {
            repository = productRepository;
        }

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.FeaturedProducts = repository.Products.Where(p => p.IsFeatured == true).ToList();
            return View();
        }
    }
}