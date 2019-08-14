using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnits
{
    class AirVehicle : Vehicle
    {
        public void TakeOff(bool rotaryWing)
        {
            
            if (rotaryWing)
            {
                Console.WriteLine("This vehicle is a Helicoptor. It can take off and land vertically");
            }
            else
            {
                Console.WriteLine("This vehicle is Fixed Wing, it can fly high in the sky but needs a runway for takeoff and landing.");
            }

        }
        public void FlightRange(bool canFlyFar)
        {
            if (!canFlyFar)
            {
                Console.WriteLine("This vehicle has a restricted range due to it being a helicoptor, and is unlikely to go further than 500 miles.");
            }
            else
            {
                Console.WriteLine("This vehicle can go a long range, flying for over 15 hours, and can be refueled in the air.");
            }
        }
        public void MovementDimensions(bool rotaryWing)
        {
            if (!rotaryWing)
            {
                Console.WriteLine("This is a Fixed Wing airplane and can only fly in two dimensions at one time: foward, backwards, up and down.");
            }
            else
            {
                Console.WriteLine("This is a Helicoptor and can fly in all three dimensions at once, forward, backward, up down, left, and right");
            }
        }
    }

}
