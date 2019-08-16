using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class TOWmissile : Anti_Armor
    {

        public TOWmissile()
        {
            Console.WriteLine("The TOW missile:\n");
            WhatItDoes();
        }
        public void WhatItDoes()
        {
            ShootsBullets();
            base.CarriedByPerson();
            DestroyArmor();
            ShoulderFired();
            base.Explosive();
        }
        public override void ShoulderFired()
        {
            Console.WriteLine("This weapon fires from a mounted position");

        }
        public override void ShootsBullets()
        {
            Console.WriteLine("This does not fire bullets");
        }
        public override void CarriedByPerson()
        {
            Console.WriteLine("This weapon is too big to be carried by a person");
        }
    }
}
