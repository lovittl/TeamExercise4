using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    public class User
    {
        decimal money = 100.00m;
                
        public void Buy() //Buy allows user to purchase cargo on a given Planet.        
        {
            double price = 00.00;
            //TODO user.buy
            Console.WriteLine("Available items for purchased:\n");
            Console.WriteLine($"1) ${price} 1 Gal Water");
            Console.WriteLine($"2) ${price} Lithum Crystals");
            Console.WriteLine($"3) ${price} Space Burger");
            Console.WriteLine($"4) ${price} Space Beer");
            //select item to be bought and pay money to buy item.
            //increase cargo in ship and decrease $ in user update Space Banner.
            //ask user what next, buy again? return to main menu?
            //leave buy menu and return to main menu.
        }
        public void Sell()
        {
            Console.WriteLine("select item to be sold, cargo decreses in ship and " +
            "money increases in user update Space Banner ask user what next, buy " +
            "again? return to main menu?");
            //TODO user.sell
            //select item to be sold, 
            //cargo decreses in ship and money increases in user 
            //update Space Banner
            //ask user what next, buy again? return to main menu?
        }

    }
}
