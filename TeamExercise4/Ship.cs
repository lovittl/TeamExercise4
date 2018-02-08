using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    public class Ship
    {
        int minSpeed;
        int maxSpeed;
        Planet currentPlanet;
        public int cargoHold = 0;

        public void TravelTo(ref Planet p, Planet[] planets)
        {
            //TODO Ship.TravelTo
            bool isValid = false;
            Console.WriteLine("Which Planet do you want to travel to");
            for (int i = 0; i < planets.Length; ++i) 
            {
                Console.WriteLine($"{i + 1}) {planets[i].name}");
            }
            do
            {
                try
                {
                    Console.WriteLine("Choose or exit(0)");
                    int selection = int.Parse(Console.ReadLine());
                    if (selection > 1 && selection <= planets.Length)
                    {
                        p = planets[selection - 1];
                        isValid = true;
                    }
                    else if (selection == 0)
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("That planet doesn't exist.");
                    }
                }
                catch (FormatException)
                {
                    isValid = false;
                }
            } while (!isValid);

        }
        public void LightYears()
        {
            //TODO Ship.LightYears()
            Console.WriteLine("calculating time traveled buffering, buffering");
            //formula to calculate time traveled based on warp speed and distance.
        }
    }
}
