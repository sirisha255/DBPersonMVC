using DBPersonMVC.Data;
using DBPersonMVC.Models;
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
        [HttpGet]
        public IActionResult Index()
        {
            return View(_dbpeople.People.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        { 
             return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            ModelState.Remove("id");
            if (ModelState.IsValid) 
            {
                 person.Id = person.Id;
                _dbpeople.People.Add(person);
                _dbpeople.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}
