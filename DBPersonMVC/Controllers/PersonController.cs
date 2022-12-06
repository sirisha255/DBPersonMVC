using Microsoft.AspNetCore.Mvc;

namespace DBPersonMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
