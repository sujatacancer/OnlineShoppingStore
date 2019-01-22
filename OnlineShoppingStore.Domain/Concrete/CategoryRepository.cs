using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DBContextjqueryMVC context = new DBContextjqueryMVC();
        public IEnumerable<Categ> CategoriesName
        {
            get
            {
               return  context.Categs;
            }
        }

        public void DeleteCategory(int CategoryId)
        {
            Categ categ= context.Categs.Find(CategoryId);
            if(categ!=null)
            {
                context.Categs.Remove(categ);
                context.SaveChanges();
            }
        }
        
        public void SaveCategory(Categ category)
        {
            Categ categ = new Categ();
            if(category.CategoryId==0)
            {
                categ.CategoryId = context.Categs.Max(c => c.CategoryId) + 1;
                context.Categs.Add(categ);
            }
            else
            {
                categ= context.Categs.FirstOrDefault(c => c.CategoryId == category.CategoryId);
            }
            categ.CategoryName = category.CategoryName;
            categ.IsActive = category.IsActive;
            categ.IsDelete = false;

            context.SaveChanges();
        }
    }
}
