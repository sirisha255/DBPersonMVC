using DBPersonMVC.Data;
using DBPersonMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBPersonMVC.Controllers
{
    public class CityDbController : Controller
    {
        readonly PeopleDbContext _peopleDb;
        public CityDbController(PeopleDbContext peopleDb)
        {
            _peopleDb = peopleDb;

        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_peopleDb.Cities.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(City city)
        {
            ModelState.Remove("id");
            if (ModelState.IsValid)
            {
                city.Id = city.Id;
                _peopleDb.Cities.Add(city);
                _peopleDb.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            var cityToRemove = _peopleDb.Cities.Find(Id);
            if (cityToRemove != null)
            {
                _peopleDb.Cities.Remove(cityToRemove);
                _peopleDb.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
