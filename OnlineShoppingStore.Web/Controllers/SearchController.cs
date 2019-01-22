using OnlineShoppingStore.Domain.Concrete;
using OnlineShoppingStore.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly DBContextjqueryMVC context = new DBContextjqueryMVC();
        // GET: Search
        public ActionResult Index(string searchKey)
        {
            ViewBag.searchKey = searchKey;

            var parameter = new SqlParameter("@searchkey",searchKey);
            List<SearchResultViewModel> sr =
                context.Database.SqlQuery<SearchResultViewModel>("USP_Search @searchkey", parameter).ToList();

            return View(sr);
        }
    }
}