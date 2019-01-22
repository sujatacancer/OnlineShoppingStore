using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.Web.Models
{
    public class SearchResultViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public decimal Price { get; set; }
    }
}