using DBPersonMVC.Data;
using DBPersonMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBPersonMVC.Controllers
{
    public class CountryDbController : Controller
    {
        readonly PeopleDbContext _peopleDb;
        public CountryDbController(PeopleDbContext peopleDb)
        {
            _peopleDb = peopleDb;

        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_peopleDb.Countries.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Country country)
        {
            ModelState.Remove("id");
            if (ModelState.IsValid)
            {
                country.Id = country.Id;
                _peopleDb.Countries.Add(country);
                _peopleDb.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            var countryToRemove = _peopleDb.Countries.Find(Id);
            if (countryToRemove != null)
            {
                _peopleDb.Countries.Remove(countryToRemove);
                _peopleDb.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
