using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class Mk19 : HeavyWeapons
    {
        public Mk19()
        {
            Console.WriteLine("The Mk 19 automatic grenage launcher:\n");
            WhatItDoes();
        }
        public void WhatItDoes()
        {
            ShootsBullets();
            base.CarriedByPerson();
            SevenSixTwo();
            base.Mounted();

        }
        public override void SevenSixTwo()
        {
            Console.WriteLine("This fires the terrifying 40mm grenade.");
        }
        public override void ShootsBullets()
        {
            Console.WriteLine("This does not fire bullets");
        }
    }
}
