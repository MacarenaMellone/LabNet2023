using Practica3.EF.Entities;
using Practica3.EF.Logic;
using Practica3.EF.Logic.DTOs;
using Practica7.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace Practica7.WebAPI.Controllers
{
    public class CategoriesController : ApiController
    {
        CategoriesLogic logic = new CategoriesLogic();
        public IHttpActionResult GetAll()
        {
            List<CategoriesDto> categories = logic.GetAll();
            List<CategoriesDto> categoriesDto = categories.Select(c => new CategoriesDto{
                CategoryID = c.CategoryID,
                CategoryName = c.CategoryName,
                Description = c.Description
            }).ToList();
            if (categoriesDto.Count == 0)
            {
                return BadRequest("Ha ocurrido un error");
            }
            return Ok(categoriesDto);
        }
        public IHttpActionResult GetId(int id)
        {
            Categories categories = logic.GetId(id);
            if (categories == null)
            {
                return BadRequest("El ID no existe.");
            }
            CategoriesDto categoriesDto = new CategoriesDto
            {
                CategoryID = categories.CategoryID,
                CategoryName = categories.CategoryName,
                Description = categories.Description
            };
            return Ok(categoriesDto);
        }
        public IHttpActionResult PostInsert(CategoriesDto categoriesDto)
        {
            try
            {
                logic.Add(categoriesDto);
                return Ok("Se ha agregado exitosamente");
            }
            catch (Exception)
            {
                return BadRequest("No se ha podido insertar, CategoryName es requerido.");
            }

        }
        public IHttpActionResult PutUpdate(CategoriesDto categoriesDto)
        { 
            
            try
            {
                logic.Update(categoriesDto);
                return Ok("Se ha editado exitosamente");
            }
            catch (Exception)
            {
                return BadRequest("No se ha podido modificar, el ID no existe.");
            }
        }
        public IHttpActionResult Delete(int id)
        {
            try
            {
                bool result = logic.Delete(id);
                if (result == true)
                {
                    return Ok("Eliminado exitosamente");
                }
                else
                {
                    return BadRequest("No se puede eliminar un ID que no existe.");
                }
            }
            catch (Exception)
            {
                return BadRequest("No se puede eliminar esta categoría, esta asociada a productos.");
            }

        }
    }
}
