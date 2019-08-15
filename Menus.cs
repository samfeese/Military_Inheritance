using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class Menus
    {
        public Menus()
        {
            MenuMain();
        }

        public static void MenuMain()
        {
            Console.Clear();
            Console.Write("Welcome to this jankey Encyclopedia, please select an option: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nF1: Vehicles || "); Console.Write("F2: Weapons || "); Console.Write("F3: Personnel");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.F1:
                    VehicleMenu();
                    break;
                case ConsoleKey.F2:
                    //WeaponsMenu();
                    break;
                case ConsoleKey.F3:
                    //PersonnelMenu();
                    break;


            }

        }
        public static void VehicleMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nF1: Land Vehicles || "); Console.Write("F2: Air Vehicles || "); Console.Write("F3: Sea Vehicles");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.F1:
                    LandVehicleMenu();
                    break;
                case ConsoleKey.F2:
                   // AirVehicleMenu();
                    break;
                case ConsoleKey.F3:
                    //SeaVehicleMenu();
                    break;


            }
        }

        public static void LandVehicleMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nF1: HMMWV || "); Console.Write("F2: Abrams || "); Console.Write("F3: Motorcycle");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.F1:
                    Hmmwv Humvee = new Hmmwv();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F2:
                    Abrams tank = new Abrams();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F3:
                    Motocycle bike = new Motocycle();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;


            }
        }

    }
}
