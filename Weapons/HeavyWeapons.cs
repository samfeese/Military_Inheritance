using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class HeavyWeapons : Weapon
    {
        public override void CarriedByPerson()
        {
            Console.WriteLine("This weapon is not able to be carried by a person");

        }
        public virtual void SevenSixTwo()
        {
            Console.WriteLine("This weapon fired a 7.62mm round");

        }
        public void Mounted()
        {
            Console.WriteLine("This weapon is mounted onto a base");
        }
    }
}
