using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class Anti_Armor : Weapon
    {
        public void DestroyArmor()
        {
            Console.WriteLine("This weapon is designed to penitrate or destroy armor");

        }
        public virtual void ShoulderFired()
        {
            Console.WriteLine("This weapon is shoulder-fired");

        }
        public void Explosive()
        {
            Console.WriteLine("This weapon has or can have an explosive payload");
        }
    }
}
