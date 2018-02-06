using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    public class User
    {
        decimal money;
                
        public void Buy() //Buy allows user to purchase cargo on a given Planet.        
        {
            Console.WriteLine("select item to be bought and pay money to buy item."+
            "increase cargo in ship and decrease $ in user and display in Space Banner."+
            "leave buy menu and return to main menu.");
            //TODO user.buy
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
