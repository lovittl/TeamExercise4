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
        User royMatt;
        Ship r1;
        Planets Earth;
        Planets AC;
        public void Run()
        {

            //Status Banner initialization
            //amoutnt $, State of cargo, Where we are
            Console.Clear();
            SpaceBanner();
            DispayMainMenu();
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
            //Buy, Sell, Travel
            Console.WriteLine("Main Menu");
            Console.WriteLine(" 1) Buy");
            Console.WriteLine(" 2) Sell");
            Console.WriteLine(" 3) Travel");
            Console.WriteLine(" 4) Exit");
            Console.Write("Please select an option:");
        }
        void ElicitUserInput()//EllicitUserInput branch created.
        {
            throw new NotImplementedException();
        }

    }
}
