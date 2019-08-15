using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits.Vehicles
{
    class Submarine : SeaVehicle
    {
        public Submarine()
        {
            WhatItCanDo();
        }
        public override void Floats()
        {
            Console.WriteLine("This vehicle travels under the water, although it can float, it is usually under the surface");
        }
        private void WhatItCanDo()
        {
            Movement(true, 4);
            Cargo(false, 0);
            People(true, 50);
            Weapons(true);
            Floats();
            NuclearPowered();

        }
    }
}
