using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    public class Planet
    {
        public string name;
        public decimal buyPrice;
        public decimal sellPrice;

        // Constructor for SpaceBanner(), qualifying name, buyPrice, and sellPrice
        public Planet(string name, decimal buyPrice, decimal sellPrice)
        {
            this.name = name;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
        }
    }
}
