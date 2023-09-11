using Practica3.EF.Entities;
using Practica3.EF.Logic;
using Practica3.EF.Logic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Practica6.EF.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic categoriesLogic = new CategoriesLogic();
        // GET: Categories
        public ActionResult Index()
        {
            List<CategoriesDto> result = categoriesLogic.GetAll();
            return View(result);
        }
        // ADD: Categories
        public ActionResult AddCategoriesView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategoriesView(CategoriesDto dto)
        {
            try
            {
                if (dto.CategoryName != null)
                {
                    var categoriesDto = new CategoriesDto
                    {
                        CategoryName = dto.CategoryName,
                        Description = dto.Description
                    };
                    categoriesLogic.Add(categoriesDto);

                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("AddCategoriesView");
                }
                
            } 
            catch (Exception){

                return RedirectToAction("Index", "Error");
            }
        }
        // Edit Categories
        public ActionResult EditView(int id)
        {
            Categories categories = categoriesLogic.GetId(id);
            CategoriesDto categoriesDto = new CategoriesDto
            {
                CategoryID = categories.CategoryID,
                CategoryName = categories.CategoryName,
                Description = categories.Description
            };
            return View(categoriesDto);

        }

        [HttpPost]
        public ActionResult EditView(CategoriesDto dto)
        {
            try
            {
                if (ModelState.IsValid) { 
                     var categoriesDto = new CategoriesDto
                    {
                        CategoryID = dto.CategoryID,
                        CategoryName = dto.CategoryName,
                        Description = dto.Description
                    };
                    categoriesLogic.Update(categoriesDto);
                    TempData["mensaje"] = "modificado Correctamente";
                    return RedirectToAction("Index");
                }
               return View();

            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
        //Delete Categories
        public ActionResult Delete(int id)
        {
            try
            {  
                bool result = categoriesLogic.Delete(id);
                return Json(new { result = result });
            }
            catch (Exception)
            {
                bool result = false;
                return Json(new { result = result });
            }
        }
    }
}