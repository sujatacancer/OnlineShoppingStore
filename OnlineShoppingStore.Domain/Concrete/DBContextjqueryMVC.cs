using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class DBContextjqueryMVC : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Categ> Categs { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
