using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class M2goose : Anti_Armor
    {

        public M2goose()
        {
            Console.WriteLine("The M2 Carl Gustav:\n");
            WhatItDoes();
        }
        public void WhatItDoes()
        {
            ShootsBullets();
            base.CarriedByPerson();
            DestroyArmor();
            base.ShoulderFired();
            Explosive();
        }
      
        public override void ShootsBullets()
        {
            Console.WriteLine("This does not fire bullets");
        }
    }
}
