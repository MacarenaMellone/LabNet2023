using System.Web.Mvc;

namespace Practica7.WebAPI.Controllers
{
    public class BaconController : Controller
    {
        // GET: Bacon
        public ActionResult Index()
        {
            return View();
        }
    }
}