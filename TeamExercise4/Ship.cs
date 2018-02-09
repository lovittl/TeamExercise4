using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    public class Ship
    {
        public int cargoHold = 0;

        // Takes ref of Planet and the planets [] and makes sure that the planet traveled to exists.
        public void TravelTo(ref Planet p, Planet[] planets)
        {
            bool isValid = false;

            Console.WriteLine("Where would you like to go?");

            for (int i = 0; i < planets.Length; ++i) 
            {
                Console.WriteLine($"{i + 1}) {planets[i].name}");
            }

            do
            {
                try
                {
                    Console.Write("Choose an item number or enter zero (0)\n" +
                                  "to return to the main menu:");
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
                        Console.WriteLine("That planet doesn't exist, try again.");
                    }
                }

                catch (FormatException)
                {
                    isValid = false;
                }
            } while (!isValid);
        }
    }
}
