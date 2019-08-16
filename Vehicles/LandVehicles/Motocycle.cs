using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class Motocycle : LandVehicle
    {
        public Motocycle()
        {
            WhatItCanDo();

        }
        private void WhatItCanDo()
        {
            Console.WriteLine($"The Motorcycle:");
            Console.WriteLine();
            base.Movement(true, 4);
            base.People(true, 1);
            base.Cargo(false, 10);
            base.Weapons(false);
            base.hasWheels(true, 2);
        }

    }
}
