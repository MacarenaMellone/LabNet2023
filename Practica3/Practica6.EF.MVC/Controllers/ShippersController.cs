using Practica3.EF.Logic.DTOs;
using Practica3.EF.Logic;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Practica3.EF.Entities;

namespace Practica6.EF.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic shippersLogic = new ShippersLogic();
        // GET: Shippers
        public ActionResult Index()
        {
            List<ShippersDto> result = shippersLogic.GetAll();
            return View(result);
        }
        // ADD: Shippers
        public ActionResult AddShippersView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddShippersView(ShippersDto dto)
        {
            try
            {
                if (dto.CompanyName != null)
                {
                    var shippersDto = new ShippersDto
                    {
                        CompanyName = dto.CompanyName,
                        Phone = dto.Phone
                    };
                    shippersLogic.Add(shippersDto);

                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("AddShippersView");
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
        // Edit Shippers
        public ActionResult EditView(int id)
        {
            Shippers shippers = shippersLogic.GetId(id);
            ShippersDto shippersDto = new ShippersDto
            {
                ShipperID = shippers.ShipperID,
                CompanyName = shippers.CompanyName,
                Phone = shippers.Phone
            };
            return View(shippersDto);
        }
        [HttpPost]
        public ActionResult EditView(ShippersDto dto)
        {
            try
            {
                var shippersDto = new ShippersDto
                {
                    ShipperID = dto.ShipperID,
                    CompanyName = dto.CompanyName,
                    Phone = dto.Phone
                };
                shippersLogic.Update(shippersDto);
                TempData["mensaje"] = "Modificado Correctamente";
                return RedirectToAction("Index"); 
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
        //Delete Shippers
        public ActionResult Delete(int id)
        {
            try
            {
                bool result = shippersLogic.Delete(id);
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