using P224ExampleTask2.Models;
using System;

namespace P224ExampleTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car("BMW F30", "Black", 65, 40, 5);
            Car car = new Car();
            car.CurrentFuel = 90;
            car.FuelCapacity = 70;
            car.Brand = "BMW";
            car.Colour = "Milioner";
            car.FuelFor1km = 10;
            car.Drive(8);
            Console.WriteLine(car.ShowInfo());
            car.Drive(10);
        }
    }
}
