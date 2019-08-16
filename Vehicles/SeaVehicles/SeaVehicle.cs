using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    public class SeaVehicle : Vehicle
    {
        public virtual void Floats()
        {
            Console.WriteLine("This vehicle floats on water");
            
        }
        public virtual void NuclearPowered()
        {
            Console.WriteLine("This vehicle is powered by a nuclear reactor, refueling once every 50 years.");

        }


    }
}
