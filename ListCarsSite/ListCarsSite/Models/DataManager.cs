using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListCarsSite.Models
{
    static public class DataManager
    {
        static int lastId = 4;
        static List<Car> Cars = new List<Car>
        {
            new Car{Id=1,Doors=4, Brand="Volvo", TopSpeed=250,},
            new Car{Id=2,Doors=5, Brand="BMW", TopSpeed=400,},
            new Car{Id=3,Doors=4, Brand="Saab", TopSpeed=301,},
            new Car{Id=4,Doors=3, Brand="Skoda", TopSpeed=150,},

        };

        public static void AddCar(CarsCreateVM newCar)
        {
            Car tempCar = new Car();
            tempCar.Brand = newCar.Brand;
            tempCar.Doors = newCar.Doors;
            tempCar.TopSpeed = newCar.TopSpeed;
            lastId++;
            tempCar.Id=lastId;
            Cars.Add(tempCar);
        }

        public static CarsCreateVM[] ListCars()
        {
            return Cars
                .Select(c => new CarsCreateVM
                {
                    Brand = c.Brand,
                    Doors = c.Doors,
                    TopSpeed = c.TopSpeed,

                }).ToArray();
        }
    }
}
