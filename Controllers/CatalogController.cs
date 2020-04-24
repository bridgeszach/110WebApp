using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Models;

namespace WebApp.Controllers
{

    public class CatalogController : Controller
    {
        private DataContext dbContext;

        public CatalogController(DataContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveCar([FromBody] Car car)
        {
            System.Console.WriteLine("Saving Car");
            System.Console.WriteLine(car.Make);

            // Save car to db
            dbContext.Cars.Add(car);
            dbContext.SaveChanges();

            //car.Id = 1;
            return Json(car);
        }

        [HttpGet]
        public IActionResult GetCatalog()
        {
            var cars = dbContext.Cars.ToList();


            return Json(cars);
        }
    }
}