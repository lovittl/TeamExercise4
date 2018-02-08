using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    class Planet
    {
        int products;
        decimal money;
        public string name;

        public decimal buyPrice;
        public decimal sellPrice;

        static void DisplayGoods()
        {
        }

        static void Sell()
        {
            Console.WriteLine("do sell stuff");
            //TODO planets.sell
        }
        public Planet(string name, decimal buyPrice, decimal sellPrice)
        {
            this.name = name;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
        }
    }
}
