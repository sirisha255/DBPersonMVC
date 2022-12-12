using DBPersonMVC.Data;
using DBPersonMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBPersonMVC.Controllers
{
    public class LanguageDbController : Controller
    {
        readonly PeopleDbContext _peopleDb;
            public LanguageDbController(PeopleDbContext peopleDb)
            {
                _peopleDb = peopleDb;

            }
            [HttpGet]
            public IActionResult Index()
            {
                return View(_peopleDb.Languages.ToList());
            }
            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Create(Language language)
            {
                ModelState.Remove("id");
                if (ModelState.IsValid)
                {
                    language.Id = language.Id;
                    _peopleDb.Languages.Add(language);
                    _peopleDb.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            public IActionResult Delete(int Id)
            {
                var languageToRemove = _peopleDb.Languages.Find(Id);
                if (languageToRemove != null)
                {
                    _peopleDb.Languages.Remove(languageToRemove);
                    _peopleDb.SaveChanges();
                }
                return RedirectToAction("Index");
            }
        }
}
