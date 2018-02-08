using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    public class GameSpaceRunner
    {
        // objects of class types
        public Planet currentPlanet;
        public User royMatt = new User();
        public Ship r1 = new Ship();
        public Planet[] planets =
            { new Planet( "Earth", 10.00m, 8.00m)
            , new Planet( "AC", 20.00m, 1000.00m)
            };

    public void Run()
    {
            //Status Banner initialization
            //amoutnt $, State of cargo, Where we are
            Console.Clear();
            SpaceBanner();
            DispayMainMenu();
            ElicitUserInput();
            //impliment array of planets
        }

        public void SpaceBanner(decimal money)
        {

            Console.WriteLine($"SPACE BANNER: Money'{money}', Location'{"Earth"}', Cargo'{42}'");
            //
        }
        void DispayMainMenu()
        {
            //moved.
            //present menu
            //menu items
            Console.WriteLine("Main Menu");
            Console.WriteLine(" 1) Buy");
            Console.WriteLine(" 2) Sell");
            Console.WriteLine(" 3) Travel");
            Console.WriteLine(" 4) Exit");
        }
        void ElicitUserInput()//Takes user input and calls method related to selection.
        {
            bool quit = false;

            do
            {
                Console.Write("Please select an option:");
                int choice = int.Parse(Console.ReadLine());
                Console.Clear();
                SpaceBanner();
                switch (choice)
                {
                    case 1:
                        royMatt.Buy(this.currentPlanet);
                        break;
                    case 2:
                        royMatt.Sell();
                        break;
                    case 3:
                        r1.TravelTo();
                        break;
                    case 4:
                        Console.WriteLine("goodbye");
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("too much space beer, try again");
                        break;
                }
            }
            while (!quit);
        }
        public GameSpaceRunner()
        {
            this.currentPlanet = planets[0];
        }

    }
}
