using Microsoft.AspNetCore.Mvc;
using AnimalShelterApp.Models;

namespace AnimalShelterApp.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() {
      return View();
    }
  }
}