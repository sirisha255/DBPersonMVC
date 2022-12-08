using DBPersonMVC.Data;
using DBPersonMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBPersonMVC.Controllers
{
    public class PersonDbController : Controller
    {
        readonly PeopleDbContext _peopleDbContext;
        public PersonDbController(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_peopleDbContext.People.ToList());
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
                _peopleDbContext.People.Add(person);
                _peopleDbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}
