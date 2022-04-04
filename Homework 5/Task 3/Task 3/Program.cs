using System;
using System.Collections.Generic;
using System.Linq;
using Task_3.Classes;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car> { 
                new Car(1, 4, "Ford", "GTR", Color.Red, 110000, DateTime.Now.AddYears(-3)),
                new Car(2, 1, "Ford", "Mustang", Color.Yellow, 96000, DateTime.Now),
                new Car(3, 6, "Audi", "Q8", Color.Red, 127000, DateTime.Now.AddYears(-1)),
                new Car(4, 3, "BMW", "X6", Color.Yellow, 89500, DateTime.Now.AddYears(-4))
            };
            List<Car> redCars = new List<Car>(), fordCars = new List<Car>(), lessThan100k = new List<Car>(); 
            // Price of red cars
            Console.WriteLine("The price of cars with the color red:");
            redCars = cars.Where(car => car.Color == Color.Red).ToList();
            redCars.ForEach(car => Console.WriteLine($"Id: {car.Id}\nBrand: {car.BrandName}\nModel: {car.ModelName}\nPrice: {car.CalculatePrice()}$\n"));
            // Price of Ford cars
            Console.WriteLine("The price of Ford cars:");
            fordCars = cars.Where(car => car.BrandName == "Ford").ToList();
            fordCars.ForEach(car => Console.WriteLine($"Id: {car.Id}\nBrand: {car.BrandName}\nModel: {car.ModelName}\nPrice: {car.CalculatePrice()}$\n"));
            // Cars with less than 100k distance travelled
            Console.WriteLine("Cars with less than 100k distance travelled:");
            lessThan100k = cars.Where(car => car.DistanceTraveled <= 100000).ToList();
            lessThan100k.ForEach(car => Console.WriteLine($"Id: {car.Id}\nBrand: {car.BrandName}\nModel: {car.ModelName}\nDistance Travelled: {car.DistanceTraveled} km\n"));
        }
    }
}
