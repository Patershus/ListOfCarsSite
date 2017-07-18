using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListCarsSite.Models;
using ListCarsSite.Models.Entities;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListCarsSite.Controllers
{
    public class CarsController : Controller
    {
        ListCarsContext context;
        public CarsController(ListCarsContext context)
        {
            this.context = context;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            //var listOfCars=DataManager.ListCars();

            var listOfCarsIndexVM = context.GetAllCars();
              
            return View(listOfCarsIndexVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarsCreateVM createdCar)
        {
            if (!ModelState.IsValid)
                return View(createdCar);

            //DataManager.AddCar(createdCar);
            await context.AddCar(createdCar);
            return RedirectToAction(nameof(Index));
        }

    }
}
