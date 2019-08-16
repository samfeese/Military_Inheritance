using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class Abrams : LandVehicle
    {


        

        public Abrams()
        {
            WhatItCanDo();
          
        }

        private void WhatItCanDo()
        {
            Console.WriteLine($"The Abrams:");
            Console.WriteLine();
            base.Movement(true, 1);
           base.People(true, 3);
           base.Cargo(false, 10);
            base.Weapons(true);
           base.hasWheels(false, 0);


        }
      


    }
}
