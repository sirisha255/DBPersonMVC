using DBPersonMVC.Data;
using DBPersonMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBPersonMVC.Controllers
{
    public class PersonDbController : Controller
    {
        readonly PeopleDbContext _peopleDb;
        public PersonDbController(PeopleDbContext peopleDb)
        {
            _peopleDb = peopleDb;
        
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_peopleDb.People.ToList());
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
                _peopleDb.People.Add(person);
                _peopleDb.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            var personToRemove = _peopleDb.People.Find(Id);
            if (personToRemove != null)
            {
                _peopleDb.People.Remove(personToRemove);
                _peopleDb.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}
