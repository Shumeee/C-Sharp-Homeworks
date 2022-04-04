using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.Classes
{
    public class Car
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public Color Color { get; set; }
        public int DistanceTraveled { get; set; }
        public DateTime DateOfModel { get; set; }

        public Car(int id, int age, string brandName, string modelName, Color color, int distanceTraveled, DateTime dateOfModel)
        {
            Id = id;
            Age = age;
            BrandName = brandName;
            ModelName = modelName;
            Color = color;
            DistanceTraveled = distanceTraveled;
            DateOfModel = dateOfModel;
        }
        public double CalculatePrice()
        {
            return (DistanceTraveled * Age) / 3;
        }
    }
}
