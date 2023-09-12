using Practica3.EF.Entities;
using Practica3.EF.Logic.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Practica3.EF.Logic
{
    public class CategoriesLogic : BaseLogic, ILogic<CategoriesDto>
    {
        public List<CategoriesDto> GetAll()
        {
            IEnumerable<Categories> categories = context.Categories.AsEnumerable();
            List<CategoriesDto> result = categories.Select(x => new CategoriesDto
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                Description = x.Description
            }).ToList();
            return result;
        }
        public void Add(CategoriesDto dto)
        {
            var newCategories = new Categories()
            {
                CategoryID = dto.CategoryID,
                CategoryName = dto.CategoryName,
                Description = dto.Description
            };
            context.Categories.Add(newCategories);
            context.SaveChanges();
        }
        public void Update(CategoriesDto dto)
        {
            Categories categoriesUpdate = context.Categories.FirstOrDefault(x => x.CategoryID == dto.CategoryID);
            if (categoriesUpdate != null)
            {
                categoriesUpdate.CategoryName = dto.CategoryName;
                categoriesUpdate.Description = dto.Description;
                context.SaveChanges();
            }
            else
            {
                ExceptionsLogic.CustomExceptionModificar();
            }  
        }
        public bool Delete(int id)
        {
            bool result = true;
            Categories categoriesDelete = context.Categories.Find(id);
            if (categoriesDelete != null)
            {
                context.Categories.Remove(categoriesDelete);
                context.SaveChanges();
            }
            else
            {
                ExceptionsLogic.CustomExceptionDelete();
            }

            return result;
        }
        public Categories GetId(int id)
        {
            return context.Categories.Find(id);
        }
    }
}
