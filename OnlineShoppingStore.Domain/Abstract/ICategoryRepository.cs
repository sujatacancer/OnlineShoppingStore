using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Abstract
{
    public interface ICategoryRepository
    {
        IEnumerable<Categ> CategoriesName { get; }
        void SaveCategory(Categ category);
        void DeleteCategory(int CategoryId);

    }
}
