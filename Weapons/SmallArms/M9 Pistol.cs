using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class M9_Pistol : SmallArms
    {
        public M9_Pistol()
        {
            Console.WriteLine("The Beretta M9:\n");
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
            Console.WriteLine("This weapon is a smaller caliber, 9mm round, and considered an emergency weapon.");
        }
    }
}
