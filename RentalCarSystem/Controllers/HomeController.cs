using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentalCarSystem.Models;
using System.Diagnostics;

namespace RentalCarSystem.Controllers
{
    [Authorize]
   
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private List<Car> cars;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           
        }

        public void GenerateDummyCars()
        {
            cars = new List<Car>{
                    new Car
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Sedan",
                        Description = "A comfortable and fuel-efficient sedan.",
                        Price = 20000,
                        Color = "Black",
                        ImagePath = "/images/sedan.jpg"
                    },
            new Car
            {
                Id = Guid.NewGuid().ToString(),
                Name = "SUV",
                Description = "A spacious SUV with all-wheel drive.",
                Price = 30000,
                Color = "White",
                ImagePath = "/images/suv.jpg"
            },
            new Car
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Convertible",
                Description = "A stylish convertible for sunny days.",
                Price = 35000,
                Color = "Red",
                ImagePath = "/images/convertible.jpg"
            },
            new Car
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Coupe",
                Description = "A sleek coupe with a powerful engine.",
                Price = 28000,
                Color = "Blue",
                ImagePath = "/images/coupe.jpg"
            },
            new Car
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Truck",
                Description = "A rugged truck with high towing capacity.",
                Price = 40000,
                Color = "Green",
                ImagePath = "/images/truck.jpg"
            }
                    };

        }
        public IActionResult Index()
        {
            GenerateDummyCars();
            return View(cars);
        }
    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
