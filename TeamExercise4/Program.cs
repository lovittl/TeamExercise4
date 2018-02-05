﻿using System;
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
            Console.WriteLine("Welcome to Interstellar Trader!");
            Console.WriteLine("In this game you can travel to worlds, trade goods, and make money.");
            Console.WriteLine(" You will aboard the Rover One spaceship, in the galactic" +
                "alliance.");
            Console.WriteLine("The objective is to become the richest space trader.");
            Console.WriteLine("Godspeed Trader!");
            Console.WriteLine("Hit enter to continue.");
            Console.ReadLine();
            GameSpaceRunner runner = new GameSpaceRunner();
            runner.Run();
        }
    }
}
