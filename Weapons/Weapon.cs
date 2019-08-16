using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class Weapon
    {

        public virtual void ShootsBullets()
        {
            Console.WriteLine("Shoots a specific bullet that is standardized by NATO.");

        }
        public virtual void CarriedByPerson()
        {
            Console.WriteLine("This weapon must be carried by a person");

        }
        
    }
}
