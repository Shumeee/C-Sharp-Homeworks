using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }
        public int CalculateSpeed(int speed, int skill)
        {
            return skill * speed;
        }
        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
            CalculateSpeed(Speed, Driver.Skill);
        }
    }
}
