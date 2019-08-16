using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    public class Vehicle
    {



        public int Movement(bool canMove, int moveModifier)
        {
            if (canMove)
            {
                int movementSpeed = 3 * moveModifier;
               
                Console.WriteLine($"This vehicle has a movement speed of: {movementSpeed} units ");
                return movementSpeed;
            }
            else return 0;

        }
        public void Cargo(bool canCarryItems, int capacityModifier)
        {
            if (canCarryItems)
            {
                int carryCapacity = 10 * capacityModifier;
                Console.WriteLine($"This vehicle can carry: {carryCapacity} units ");
              
            }
            else {
                Console.WriteLine($"This vehicle cannot carry any cargo units ");
            
            }
        }
        public int People(bool hasDriver, int numberOfSeats)
        {
            if (hasDriver)
            {
                int peopleCarried = numberOfSeats;
                Console.WriteLine($"This vehicle carries {peopleCarried} people.");
                return peopleCarried;
            }

            else
            {
                Console.WriteLine("This unit is a Drone");
                return 0;
            }

        }
        public void Weapons(bool hasWeapons)
        {


            if (hasWeapons)
            {
                string weapons = "can equip weapons";
                Console.WriteLine($"This vehicle {weapons}");
               
            }
            else
            {
                string weapons = "can not equip weapons";
                Console.WriteLine($"This vehicle {weapons}");
              
            }
        }


    }
}
