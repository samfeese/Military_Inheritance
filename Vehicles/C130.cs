using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class C130 : AirVehicle
    {
        public C130()
        {
            WhatItCanDo();
        }
        private void WhatItCanDo()
        {
            Console.WriteLine($"The C130:");
            Console.WriteLine();
            base.Movement(true, 4);
            base.People(true, 64);
            base.Cargo(true, 100);
            base.Weapons(false);
            base.TakeOff(false);
            base.FlightRange(true);
            base.MovementDimensions(false);
        }
    }
}
