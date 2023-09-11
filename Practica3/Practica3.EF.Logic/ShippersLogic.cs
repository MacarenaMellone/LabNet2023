using Practica3.EF.Entities;
using Practica3.EF.Logic.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace Practica3.EF.Logic
{
    public class ShippersLogic : BaseLogic, ILogic<ShippersDto>
    {
        public List<ShippersDto> GetAll()
        {
            IEnumerable<Shippers> shippers = context.Shippers.AsEnumerable();
            List<ShippersDto> result = shippers.Select(s => new ShippersDto
            {
                ShipperID = s.ShipperID,
                CompanyName = s.CompanyName,
                Phone = s.Phone,
            }).ToList();
            return result;
        }
        public void Add(ShippersDto dto)
        {
            var newShipper = new Shippers()
            {
                ShipperID = dto.ShipperID,
                CompanyName = dto.CompanyName,
                Phone = dto.Phone,
            };
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }
        public void Update(ShippersDto dto)
        {
            var shippersUpdate = context.Shippers.FirstOrDefault(s => s.ShipperID == dto.ShipperID);
            if (shippersUpdate != null) {
                shippersUpdate.CompanyName = dto.CompanyName;
                shippersUpdate.Phone = dto.Phone;
                context.SaveChanges();
            
            }
            else{
                ExceptionsLogic.CustomExceptionModificar();
            }   
        }
        public bool Delete(int id)
        {
            bool result = false;
            var shipperDelete = context.Shippers.Find(id);
            if (shipperDelete != null)
            {
                context.Shippers.Remove(shipperDelete);
                context.SaveChanges();
            }
            else
            {
                ExceptionsLogic.CustomExceptionDelete();
            }
            return result;
        }
    }
}
