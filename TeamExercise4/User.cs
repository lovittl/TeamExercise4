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
                            if (total > 0 && total <= money)
                            {
                                Console.WriteLine($"Your total: ${total}");
                                money -= total;
                            }
                            else
                            {
                                isValid = false;
                                Console.Write("Insufficient Funds");
                            }
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
        public int Sell(int cargo, Planet presentPlanet)
        {
            bool isValid = false;
            int quantity = 0;
            Console.Write($"You have {cargo} Space Beers. They sell for {presentPlanet.sellPrice}" +
                "How many would you like to sell?");
            do
            {
                try
                {
                    quantity = int.Parse(Console.ReadLine());
                    if (quantity >= 0 && quantity <= cargo)
                    {
                        money += quantity * presentPlanet.sellPrice;
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("You can't do that.");
                    }
                }
                catch (FormatException ex2)
                {
                    isValid = false;
                }
            }
            while (!isValid);
            return quantity;
        }
        public User()
        {
            this.currentUser = money;
        }
    }
}
