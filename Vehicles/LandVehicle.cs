using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class LandVehicle : Vehicle
    {
        
        public void hasWheels(bool hasWheels, int wheels)
        {
            if (hasWheels && wheels == 4)
            {
                
                Console.WriteLine("This has 4 wheels and is a truck.");

            }
            if (hasWheels && wheels == 2)
            {

                
                Console.WriteLine("This has 2 wheels and is a motorcycle.");
               
            }
            else
            {
                Console.WriteLine("This Vehicle has Tracks."); 
               
            } 
               
        }
        public string hasTracks()
        {
            var notice = "This Vehicle has Tracks.";
            return notice;
        }


       
       

    }
}
