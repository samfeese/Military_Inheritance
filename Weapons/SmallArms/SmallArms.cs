
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MilitaryUnits
{
    class SmallArms : Weapon
    {
        public virtual void AntiInfantry()
        {
            Console.WriteLine("This weapons primary use is anti-infantry, as small arms are not powerful enough to destroy armor.");
        }
        public virtual void FiveFiveSix()
        {
            Console.WriteLine("This weapon has a standard 5.56mm round");
        }
        public void EasyToTransport()
        {
            Console.WriteLine("This weapon is easy to transport by an individual, and is easily maintained");
        }
    }
}