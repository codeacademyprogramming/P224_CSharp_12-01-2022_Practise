using System;
using System.Collections.Generic;
using System.Text;

namespace P224ExampleTask2.Models
{
    class Car : Vehicle
    {
        public double FuelCapacity {
            get
            {
                return _fuelCapacity;
            }
            set
            {
                if (value < _currentFuel)
                {
                    Console.WriteLine("Ola bilmez.");
                    return;
                }
                _fuelCapacity = value;
            }
        }
        private double _fuelCapacity;

        public double CurrentFuel {
            get
            {
                return _currentFuel;
            }
            set
            {
                if (value > _fuelCapacity)
                {
                    Console.WriteLine("Ola bilmez.");
                    return;
                }
                _currentFuel = value;
            }
        }
        private double _currentFuel;

        public double FuelFor1km { get; set; }

        //public Car(string brand, string colour, double fuelCapacity, double currentFuel, double fuelFor1km)
        //{
        //    Brand = brand;
        //    Colour = colour;
        //    FuelCapacity = fuelCapacity;
        //    CurrentFuel = currentFuel;
        //    FuelFor1km = fuelFor1km;
        //}

        public override void Drive(double km)
        {
            if (_currentFuel >= FuelFor1km * km)
            {
                _currentFuel -= FuelFor1km * km;
                Millage += km;
            }
            else
            {
                Console.WriteLine($"{km} km mesafe ucun kifayet qeder benzin yoxdur...");
            }
        }

        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\nFuel Capacity: {FuelCapacity}\nCurrent Fuel: {CurrentFuel}\nMillage: {Millage}";
        }
    }
}
