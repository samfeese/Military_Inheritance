using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits.Vehicles
{
    class Dingy : SeaVehicle
    {
        public Dingy()
        {
            WhatItCanDo();
        }
        public override void NuclearPowered()
        {
            Console.WriteLine("This vehicle is small and agile, fueled by desiel fuel.");
        }
        private void WhatItCanDo()
        {
            Movement(true, 3);
            Cargo(false, 0);
            People(true, 6);
            Weapons(true);
            Floats();
            NuclearPowered();

        }

    }

}
