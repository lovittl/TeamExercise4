using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Splash screen explaining a background on the game
            Console.WriteLine("** WELCOME TO INTERSTELLAR TRADER! **\n");
            Console.WriteLine("In this game you can travel to different planets, trade goods, " +
                              "and make money.\n");
            Console.WriteLine("You are aboard the Rover One spaceship.\n");
            Console.WriteLine("Your objective is to buy, sell, and travel your way through the " +
                              "galaxy.\n");
            Console.WriteLine("Godspeed Trader!\n");
            Console.WriteLine("Hit enter to continue.");
            Console.ReadLine();

            // Creates an instance of the GameSpaceRunner class
            GameSpaceRunner runner = new GameSpaceRunner();
            runner.Run();

        }
    }
}
