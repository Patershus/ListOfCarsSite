using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

namespace ListCarsSite.Models.Entities
{
    public partial class ListCarsContext : DbContext
    {
      


        public ListCarsContext(DbContextOptions<ListCarsContext> options) : base(options)
        {

        }


        public CarsIndexVM[] GetAllCars()
        {
            return this.Car
                .Select(c => new CarsIndexVM
                {
                    Brand = c.Brand,
                    ShowAsFast=c.TopSpeed>300,

                }).ToArray();
        }


        internal void AddCar(CarsCreateVM newCar)
        {
            this.Car.Add(new Car
            {
                Brand = newCar.Brand,
                Doors = newCar.Doors,
                TopSpeed = newCar.TopSpeed,
            });
            this.SaveChanges();
                     
        }
    }
}