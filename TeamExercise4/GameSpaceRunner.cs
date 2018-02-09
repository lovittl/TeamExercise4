using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    public class GameSpaceRunner
    {
        // Objects of class types
        public Planet currentPlanet;
        public User royMatt = new User();
        public Ship r1 = new Ship();
        public Planet[] planets =
         { new Planet( "Earth", 10.00m, 8.00m)
         , new Planet( "AC", 20.00m, 1000.00m)
         };
       
        // Allows user to play the game until they are done and choose to quit
        public void Run()
        {
            bool quit;

            do
            {
                Console.Clear();
                SpaceBanner();
                DispayMainMenu();
                quit = ElicitUserInput();
            }
            while (!quit);
        }
        
        // Displays money, location, and cargo
        public void SpaceBanner()
        {

            Console.WriteLine($" SPACE BANNER | ${royMatt.money} | {currentPlanet.name}" +
                              $" | {r1.cargoHold} Space Beers |");
        }
        
        // Displays main menu options
        void DispayMainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine(" 1) Buy");
            Console.WriteLine(" 2) Sell");
            Console.WriteLine(" 3) Travel");
            Console.WriteLine(" 4) Exit");
        }
        
        // Handles main navigation from the user
        bool ElicitUserInput()
        {
            bool quit = false;
            bool isValid = false;

            do
            {
                try
                {
                    Console.Write("Please select an option:");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    SpaceBanner();
                    isValid = true;

                    switch (choice)
                    {
                        case 1:
                            r1.cargoHold += royMatt.Buy(this.currentPlanet);
                            break;

                        case 2:
                            r1.cargoHold -= royMatt.Sell(r1.cargoHold, this.currentPlanet);
                            break;

                        case 3:
                            r1.TravelTo(ref this.currentPlanet, planets);
                            break;

                        case 4:
                            Console.WriteLine("\nThanks for playing! Until your next adventure!\n");
                            Console.ReadLine();
                            quit = true;
                            break;

                        default:
                            isValid = false;
                            Console.WriteLine("You've had too much space beer, please try again.");
                            break;
                    }
                }

                catch (FormatException)
                {
                    isValid = false;
                }
            }
            while (!quit && !isValid);

            return quit;
        }

        // Constructor qualifies planets array
        public GameSpaceRunner()
        {
            this.currentPlanet = planets[0];
        }

    }
}
