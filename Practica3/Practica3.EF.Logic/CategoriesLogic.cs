using Practica3.EF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Practica3.EF.Logic
{
    public class CategoriesLogic : BaseLogic, ILogic<Categories>
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }
        public void Add(Categories newCategories)
        {
            context.Categories.Add(newCategories);
            context.SaveChanges();
        }
        public void Update(Categories categories)
        {
            var categoriesUpdate = context.Categories.Find(categories.CategoryID);
            if (categoriesUpdate != null)
            {
                categoriesUpdate.CategoryName = categories.CategoryName;
                categoriesUpdate.Description = categories.Description;
                context.SaveChanges();
            }
            else
            {
                ExceptionsLogic.CustomExceptionModificar();
            }  
        }
        public void Delete(int id)
        {
            var categoriesDelete = context.Categories.Find(id);
            if (categoriesDelete != null)
            {
                context.Categories.Remove(categoriesDelete);
                context.SaveChanges();
            }
            else
            {
                ExceptionsLogic.CustomExceptionDelete();
            }
        }
    }
}
