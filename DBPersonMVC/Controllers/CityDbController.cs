using Microsoft.AspNetCore.Mvc;

namespace DBPersonMVC.Controllers
{
    public class CityDbController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
