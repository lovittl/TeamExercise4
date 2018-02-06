using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    class GameSpaceRunner
    {
        // objects of class types
        public User royMatt = new User();
        public Ship r1 = new Ship();
        public Planets Earth = new Planets();
        public Planets AC = new Planets();
        public void Run()
        {

            //Status Banner initialization
            //amoutnt $, State of cargo, Where we are
            Console.Clear();
            SpaceBanner();
            DispayMainMenu();
            ElicitUserInput();
        }
        public void SpaceBanner()
        {
            Console.WriteLine($"SPACE BANNER: Money'{100}', Location'{"Earth"}', Cargo'{42}'");
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
            Console.Write("Please select an option:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    royMatt.Buy();
                    break;
                case 2:
                    royMatt.Sell();
                    break;
                case 3:
                    r1.TravelTo();
                    break;
                case 4:
                    Console.WriteLine("goodbye");
                    break;
                default:
                    Console.WriteLine("too much space beer, try again");
                    break;
            }
                

        }

    }
}
