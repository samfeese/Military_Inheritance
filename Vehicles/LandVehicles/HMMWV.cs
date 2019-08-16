using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class Hmmwv : LandVehicle
    {
       

        public Hmmwv()
        {
            WhatItCanDo();
           
        }

        private void WhatItCanDo()
        {
            Console.WriteLine($"The HMMWV:");
            Console.WriteLine();
            base.Movement(true, 2);
            base.People(true, 4);
            base.Cargo(true, 10);
            base.Weapons(true);
            base.hasWheels(true, 4);


        }
       

    }
}
