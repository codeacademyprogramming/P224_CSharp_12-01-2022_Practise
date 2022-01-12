using System;
using System.Collections.Generic;
using System.Text;

namespace P224ExampleTask2.Models
{
    class Bcycle : Vehicle
    {
        public override void Drive(double km)
        {
            Millage += km;
        }
    }
}
