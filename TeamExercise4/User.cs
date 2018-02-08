using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    public class User
    {

        public decimal currentUser;
        public decimal money = 100.00m;
          //take a current planet parameter.      
        public int Buy(Planet currentPlanet) //Buy allows user to purchase cargo on a given Planet.        
        {
            bool isValid = false;
            int quantity = 0;
            //TODO user.buy
            Console.WriteLine("Available items for purchased:\n");
            Console.WriteLine("1) Space Beer");
            Console.WriteLine("2) Main Menu");
            //increase cargo in ship and decrease $ in user update Space Banner.
            //ask user what next, buy again? return to main menu?
            //leave buy menu and return to main menu.
            
            do
            {
                Console.Write("Choose the item you wish to buy. Enter the item number:");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    isValid = true;
                    switch (choice)
                    {
                        //select item to be bought and pay money to buy item.
                        case 1:
                            Console.WriteLine("\nSpace Beer:");
                            Console.WriteLine($"Beer costs {currentPlanet.buyPrice} on {currentPlanet.name}");
                            Console.Write("\nEnter the number of beers you would like to purchase:");
                            quantity = int.Parse(Console.ReadLine());
                            decimal total = quantity * currentPlanet.buyPrice;
                            Console.WriteLine($"Your total: ${total}");
                            money -= total;
                            break;
                        case 2:
                            isValid = true;
                            break;
                        default:
                            isValid = false;
                            Console.WriteLine();
                            break;
                    }
                }
                catch (FormatException ex1)
                {
                    isValid = false;
                }
            } while (!isValid);
            return quantity;
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
        public User()
        {
            this.currentUser = money;
        }
    }
}
