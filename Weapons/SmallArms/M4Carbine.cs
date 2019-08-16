using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class M4Carbine : SmallArms     
    {
        public M4Carbine()
        {
            Console.WriteLine("The M4A1 Carbine:\n");
            WhatItDoes();
        }
        public void WhatItDoes()
        {
            base.ShootsBullets();
            base.CarriedByPerson();
            base.AntiInfantry();
            base.FiveFiveSix();
            base.EasyToTransport();
        }
    }
}
