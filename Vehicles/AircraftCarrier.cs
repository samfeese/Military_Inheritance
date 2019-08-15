using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits.Vehicles
{
    class AircraftCarrier : SeaVehicle
    {
        public AircraftCarrier()
        {
            WhatItCanDo();
        }
       
      
        private void WhatItCanDo()
        {
            Movement(true, 1);
            Cargo(true, 1000);
            People(true, 5000);
            Weapons(true);
            Floats();
            NuclearPowered();

        }
    }
}
