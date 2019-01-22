using OnlineShoppingStore.Domain.Concrete;
using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Utility
{
    public  class Utility
    {
        private readonly DBContextjqueryMVC context = new DBContextjqueryMVC();
        
        public IEnumerable<Menu> DisplayMenu()
        {
            IEnumerable<Menu> menus= context.Menus.ToList();
           
            return menus;
        }

        public List<string> DisplayMenu1()
        {
            List<string> menu = new List<string>();
            menu.Add("Dashboard");
            menu.Add("Categories");
            menu.Add("Products");
            return menu;
        }
    }
}
