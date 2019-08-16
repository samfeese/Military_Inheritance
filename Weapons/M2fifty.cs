using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class M2fifty : HeavyWeapons
    {
        public M2fifty()
        {
            Console.WriteLine("The M2 Fifty Cal:\n");
            WhatItDoes();
        }
        public void WhatItDoes()
        {
            base.ShootsBullets();
            base.CarriedByPerson();
            SevenSixTwo();
            base.Mounted();

        }
        public override void SevenSixTwo()
        {
            Console.WriteLine("This fires the huge .50 caliber BMG");
        }

    }
}
