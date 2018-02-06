using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    class Ship
    {
        int minSpeed;
        int maxSpeed;
        Planets currentPlanet;

        public void TravelTo()
        {
            //TODO Ship.TravelTo
            Console.WriteLine("Which Planet do you want to travel to");
            //ask user which planet would you like to travel to?
            //present user with list of Planets to travel to.
            //user selects planet and warp speed to travel at.
            //ship warps to planet and data about the warp is calculated and t+S+D stored
              //in Ship.LightYears.
            //user is presented with warp data.
            //update SpaceBanner Location field and time elapsed during last warp.
        }
        public void LightYears()
        {
            //TODO Ship.LightYears()
            Console.WriteLine("calculating time traveled buffering, buffering");
            //formula to calculate time traveled based on warp speed and distance.
        }
    }
}
