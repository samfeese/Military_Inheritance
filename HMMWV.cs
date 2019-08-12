using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class Hmmwv : LandVehicle
    {
        public static int speed;
        public static int peopleCarried;
        public static int cargoSpots;
        public static string weapons;

        public static int wheelCount;

        public Hmmwv()
        {
            WhatItCanDo();
            DisplayAttributes();
        }

        private void WhatItCanDo()
        {
            speed = base.Movement(true, 2);
            peopleCarried = base.People(true, 4);
            cargoSpots = base.Cargo(true, 10);
            weapons = base.Weapons(true);

            wheelCount = base.hasWheels(true, 4);


        }
      public static void DisplayAttributes()
        {
            Console.WriteLine($"The HMMWV:");
            Console.WriteLine($"\nSpeed: has {wheelCount} wheels and a base of {speed} speed.");
            Console.WriteLine($"Can carry: {peopleCarried} people.");
            Console.WriteLine($"Can carry: {cargoSpots} goods at one time.");
            Console.WriteLine($"{weapons}");
        }

    }
}
