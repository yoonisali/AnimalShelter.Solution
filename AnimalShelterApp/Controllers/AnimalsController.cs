using Microsoft.AspNetCore.Mvc;
using AnimalShelterApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelterApp.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly AnimalShelterContext _db;

        public AnimalsController(AnimalShelterContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Animal> model = _db.Animals.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Display(int id)
        {
            Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.Id == id);
            return View(thisAnimal);
        }


    }
}