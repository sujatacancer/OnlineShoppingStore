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
    public class CategoryController : Controller
    {
        public ICategoryRepository repository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            repository = categoryRepository;
        }
        // GET: Category
        public ActionResult LoadCategory()
        {   
            return View(repository.CategoriesName);
        }
        public ViewResult AddUpdateCateogry(int CategoryId)
        {
            if(CategoryId > 0)
            {
                Categ categ = repository.CategoriesName.FirstOrDefault(c => c.CategoryId==CategoryId);
                return View(categ);
            }
            else
                return View();

        }
        [HttpPost]
        public ActionResult AddUpdateCateogry(Categ category)
        {
            if (ModelState.IsValid)
            {
                repository.SaveCategory(category);
                return Content("True");
            }
            else
                return Content("False");
        }
        [HttpPost]
        public ActionResult DeleteCateogry(int categoryId)
        {
            if (ModelState.IsValid)
            {
                repository.DeleteCategory(categoryId);
                return Content("True");
            }
            else
                return Content("False");
        }

        public JsonResult CheckCategoryExist(string CategoryName)
        {
            int CategoryId = 0;
            if (HttpUtility.ParseQueryString(Request.UrlReferrer.Query)["categoryId"] != null)
                CategoryId = Convert.ToInt32(HttpUtility.ParseQueryString(Request.UrlReferrer.Query)["categoryId"]);
            var CategoryExist = repository.CategoriesName.Where(i => i.CategoryName == CategoryName && i.CategoryId != CategoryId && i.IsActive == true && i.IsDelete == false).Count();

            return CategoryExist == 0 ? Json(true, JsonRequestBehavior.AllowGet) : Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}