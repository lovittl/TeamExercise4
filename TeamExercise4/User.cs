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
        
        // Buy() allows user to purchase cargo on a given Planet      
        public int Buy(Planet currentPlanet)        
        {
            bool isValid = false;
            int quantity = 0;

            Console.WriteLine("Available items for purchased:");
            Console.WriteLine("1) Space Beer");
            Console.WriteLine("2) Main Menu");

            do
            {
                Console.Write("Choose item number you wish to buy or return the main menu:");

                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    isValid = true;
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nSpace Beer:");
                            Console.WriteLine($"${currentPlanet.buyPrice} on {currentPlanet.name}");
                            Console.Write("\nEnter the number of beers you would like to purchase" +
                                          " or return to the main menu:");

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
                                Console.Write("Insufficient Funds!\n");
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

                catch (FormatException)
                {
                    isValid = false;
                }
            } while (!isValid);

            return quantity;
        }
        
        // Sell() allows user to sell items in cargo and if sold the cargo and money statuses are
        // are updated in the SpaceBanner()
        public int Sell(int cargo, Planet presentPlanet)
        {
            bool isValid = false;
            int quantity = 0;

            Console.WriteLine("Space Beer:");
            Console.Write($"${presentPlanet.sellPrice} a Beer.\n");
            Console.Write("\nEnter the number of beers you wish to sell or enter \n" +
                          "zero (0) to return to the main menu:");
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
                        Console.WriteLine("You can't do that, please enter number of Beers you " +
                                          "wish to sell");
                    }
                }

                catch (FormatException)
                {
                    isValid = false;
                }
            }
            while (!isValid);

            return quantity;
        }
        
        // Qualifies the field, money
        public User()
        {
            this.currentUser = money;
        }
    }
}
