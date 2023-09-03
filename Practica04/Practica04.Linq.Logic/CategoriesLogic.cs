using Practica04.Linq.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Practica04.Linq.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }
        //Ejer.11
        public List<Categories> CategoriesProducts()
        {
            var query = context.Categories
                .Join(context.Products,
                c => c.CategoryID,
                p => p.CategoryID,
                (c, p) => c);
            return query.ToList();
        }
    }
}
