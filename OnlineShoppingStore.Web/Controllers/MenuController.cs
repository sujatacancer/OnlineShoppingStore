using OnlineShoppingStore.Domain.Entities;
using OnlineShoppingStore.Domain.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.Web.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public PartialViewResult LoadMenu()
        {
            Utility utility = new Utility();
            return PartialView(utility.DisplayMenu1());
        }
    }
}