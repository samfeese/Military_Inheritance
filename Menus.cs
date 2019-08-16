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
                    WeaponsMenu();
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
        public static void AirVehicleMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nF1: C130 || "); Console.Write("F2: Predator || "); Console.Write("F3: Apache");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.F1:
                    C130 plane = new C130();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F2:
                    Predator drone = new Predator();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F3:
                    Apache heli = new Apache();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;


            }
        }
        public static void SeaVehicleMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nF1: Carrier || "); Console.Write("F2: Submerine || "); Console.Write("F3: Boat");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.F1:
                    AircraftCarrier carrier = new AircraftCarrier();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F2:
                    Submarine sub = new Submarine();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F3:
                    Dingy boat = new Dingy();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;


            }
        }
        public static void WeaponsMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nF1: Small Arms || "); Console.Write("F2: Heavy Weapons || "); Console.Write("F3: Anti-Armor");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.F1:
                    SmallArmsMenu();

                    break;
                case ConsoleKey.F2:
                    HeavyWeaponsMenu();
                    break;
                case ConsoleKey.F3:
                    AntiTankMenu();
                    break;


            }
        }
        public static void SmallArmsMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nF1: M4 || "); Console.Write("F2: M240B || "); Console.Write("F3: M9");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.F1:
                    M4Carbine m4 = new M4Carbine();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F2:
                    M240B machineGun = new M240B();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F3:
                    M9_Pistol pistol = new M9_Pistol();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;


            }
        }
        public static void HeavyWeaponsMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nF1: M2 Fifty Cal || "); Console.Write("F2: MK19 || "); Console.Write("F3: NULL");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.F1:
                    M2fifty fifty = new M2fifty();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F2:
                    Mk19 gl = new Mk19();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F3:
                    Console.WriteLine("THIS FEILD IS EMPTY");
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;


            }
        }
        public static void AntiTankMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nF1: TOW || "); Console.Write("F2: M2 Carl G || "); Console.Write("F3: NULL");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.F1:
                    TOWmissile tow = new TOWmissile();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F2:
                    M2goose carlG = new M2goose();
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;
                case ConsoleKey.F3:
                    Console.WriteLine("THIS FEILD IS EMPTY");
                    Console.WriteLine("\n\nPress ANY KEY to return to Menu");
                    Console.ReadKey();
                    MenuMain();
                    break;


            }
        }
    }
}
