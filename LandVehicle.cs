using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class LandVehicle : Vehicle
    {
        public int hasWheels(bool hasWheels, int wheels)
        {
            if (hasWheels && wheels == 4)
            {
                int wheelCount = 4;
                return wheelCount;
            }
            if (hasWheels && wheels == 2)
            {
                int wheelCount = 2;
                return wheelCount;
            }
            else
            {
                hasTracks();
                return 0;
            }
               
        }
        public string hasTracks()
        {
            var notice = "This Vehicle has Tracks.";
            return notice;
        }


       
       

    }
}
