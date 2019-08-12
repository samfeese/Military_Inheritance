using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class Vehicle
    {



        public int Movement(bool canMove, int moveModifier)
        {
            if (canMove)
            {
                int movementSpeed = 3 * moveModifier;
                return movementSpeed;
            }
            else return 0;

        }
        public int Cargo(bool canCarryItems, int capacityModifier)
        {
            if (canCarryItems)
            {
                int carryCapacity = 10 * capacityModifier;
                return carryCapacity;
            }
            else return 0;
        }
        public int People(bool hasDriver, int numberOfSeats)
        {
            if (hasDriver)
            {
                int peopleCarried = numberOfSeats;
                return peopleCarried;
            }
            else return 0;

        }
        public string Weapons(bool hasWeapons)
        {


            if (hasWeapons)
            {
                string weapons = "can equip weapons";
                return weapons;
            }
            else
            {
                string weapons = "can not equip weapons";
                return weapons;
            }
        }


    }
}
