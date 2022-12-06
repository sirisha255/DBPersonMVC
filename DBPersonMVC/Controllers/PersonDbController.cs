using DBPersonMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace DBPersonMVC.Controllers
{
    public class PersonDbController : Controller
    {
        readonly PeopleDbContext _dbpeople;
        public PersonDbController(PeopleDbContext dbpeople)
        {
            _dbpeople = dbpeople;
        
        }
        public IActionResult Index()
        {
            return View(_dbpeople.People.ToList());
        }
    }
}
