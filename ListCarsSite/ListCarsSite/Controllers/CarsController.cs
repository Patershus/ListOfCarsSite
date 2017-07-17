using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListCarsSite.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListCarsSite.Controllers
{
    public class CarsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var listOfCars=DataManager.ListCars();
            var listOfCarsIndexVM =listOfCars
                .Select(c => new CarsIndexVM
                {
                    Brand=c.Brand,
                    ShowAsFast=c.TopSpeed>300,
                }).ToArray();

            return View(listOfCarsIndexVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarsCreateVM createdCar)
        {
            if (!ModelState.IsValid)
                return View(createdCar);

            DataManager.AddCar(createdCar);
            return RedirectToAction(nameof(Index));
        }

    }
}
