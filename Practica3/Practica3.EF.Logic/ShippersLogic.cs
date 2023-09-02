using Practica3.EF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Practica3.EF.Logic
{
    public class ShippersLogic : BaseLogic, ILogic<Shippers>
    {
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }
        public void Add(Shippers newShipper)
        {
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }
        public void Update(Shippers updateShipper)
        {
            var shippersUpdate = context.Shippers.FirstOrDefault(s => s.ShipperID == updateShipper.ShipperID);
            if (shippersUpdate != null) {
                shippersUpdate.CompanyName = updateShipper.CompanyName;
                shippersUpdate.Phone = updateShipper.Phone;
                context.SaveChanges();
            
            }
            else{
                ExceptionsLogic.CustomExceptionModificar();
            }   
        }
        public void Delete(int id)
        {
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
        }
    }
}
