using Practica3.EF.Entities;
using Practica3.EF.Logic;
using Practica3.EF.Logic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Practica7.WebAPI.Controllers
{
    public class ShippersController : ApiController
    {
        ShippersLogic logic = new ShippersLogic();
        public IHttpActionResult GetAll()
        {
            List<ShippersDto> shippers = logic.GetAll();
            List<ShippersDto> shippersDto = shippers.Select(s => new ShippersDto
            {
                ShipperID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone
            }).ToList();
            if (shippersDto.Count == 0)
            {
                return BadRequest("Ha ocurrido un error.");
            }
            return Ok(shippersDto);
        }
        public IHttpActionResult GetId(int id)
        {
            Shippers shippers = logic.GetId(id);
            if (shippers == null)
            {
                return BadRequest("El ID no existe.");
            }
            ShippersDto shippersDto = new ShippersDto
            {
                ShipperID = shippers.ShipperID,
                CompanyName = shippers.CompanyName,
                Phone = shippers.Phone
            };
            return Ok(shippersDto);
        }
        public IHttpActionResult PostInsert(ShippersDto shippersDto)
        {
            try
            {
                logic.Add(shippersDto);
                return Ok("Se ha agregado exitosamente.");
            }
            catch (Exception)
            {
                return BadRequest("No se ha podido insertar, CompanyName es requerido.");
            }
        }
        public IHttpActionResult PutUpdate(ShippersDto shippersDto)
        {
            bool result = logic.Update(shippersDto);
            if (result == true)
            {
                return Ok("Se ha editado exitosamente.");
            }
            else
            {
                return BadRequest("No se ha podido modificar, el ID no existe.");
            }
        }
        public IHttpActionResult Delete(int id)
        {
            bool result = logic.Delete(id);
            if (result == true)
            {
                return Ok("Eliminado exitosamente.");
            }
            else
            {
                return BadRequest("No se puede eliminar un ID que no existe.");
            }
        }
    }
}
