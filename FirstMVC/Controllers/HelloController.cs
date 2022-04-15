using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel dilbert = new DogViewModel() {Name = "Dilbert", Age = 4 };
            return View(dilbert);
        }
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {

            return View("Index");
        }
    }
}
