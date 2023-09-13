using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica7.WebAPI.Controllers
{
    public class ChuckController : Controller
    {
        // GET: Chuck
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Chuck()
        {
            return Redirect("https://api.chucknorris.io/jokes/random");
        }
    }
}