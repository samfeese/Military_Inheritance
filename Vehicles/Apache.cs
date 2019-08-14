using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class Apache : AirVehicle
    {

        public Apache()
        {
            WhatItCanDo();
        }
        private void WhatItCanDo()
        {
            Console.WriteLine($"The Apache:");
            Console.WriteLine();
            base.Movement(true, 3);
            base.People(true, 2);
            base.Cargo(false, 10);
            base.Weapons(true);
            base.TakeOff(true);
            base.FlightRange(false);
            base.MovementDimensions(true);
        }
    }
}
