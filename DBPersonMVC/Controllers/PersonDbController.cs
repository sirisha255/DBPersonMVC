using DBPersonMVC.Data;
using DBPersonMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBPersonMVC.Controllers
{
    public class PersonDbController : Controller
    {
        readonly PeopleDbContext _person;
        public PersonDbController(PeopleDbContext person)
        {
            _person = person;
        
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_person.People.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        { 
             return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid) 
            {
                 person.Id = person.Id;
                _person.People.Add(person);
                _person.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}
