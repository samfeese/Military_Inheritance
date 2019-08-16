using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class Predator : AirVehicle
    {
        public Predator()
        {
            WhatItCanDo();
        }
        private void WhatItCanDo()
        {
            Console.WriteLine($"The Predator:");
            Console.WriteLine();
            base.Movement(true, 3);
            base.People(false, 2);
            base.Cargo(false, 10);
            base.Weapons(true);
            base.TakeOff(false);
            base.FlightRange(true);
            base.MovementDimensions(false);
        }
    }
}
