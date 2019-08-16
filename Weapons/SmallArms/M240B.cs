using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class M240B : SmallArms
    {
        public M240B()
        {
            Console.WriteLine("The FN M240B:\n");
            WhatItDoes();
        }
        public void WhatItDoes()
        {
            base.ShootsBullets();
            base.CarriedByPerson();
            base.AntiInfantry();
            FiveFiveSix();
            base.EasyToTransport();
        }
        public override void FiveFiveSix()
        {
            Console.WriteLine("This weapon is a larger caliber, 7.62mm round, and considered a medium machine gun.");
        }
    }
}
