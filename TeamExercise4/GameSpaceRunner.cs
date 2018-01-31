using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamExercise4
{
    class GameSpaceRunner
    {
        User royMatt;
        Ship r1;
        Planets Earth;
        Planets AC;

        internal void Run()
        {

            //Status Banner initialization
            //amoutnt $, State of cargo, Where we are
            Console.WriteLine("Space Banner");
            Console.WriteLine($"$ Money'{100}', Location'{"Earth"}', Cargo'{42}'");
            Console.WriteLine("Main Menu");





            //present menu
            //menu items
            //Buy, Sell, Travel

            //Buy Menu
            //present list of items to select from
            //water, dilithum crystal
            //water is stored ship
            //reduce $
            //display cargo inventory and $ balance
            //present main menu
            //Sell Menu
            //present list of items to select from
            //water, dilithum crystal
            //cargo updated and displayed in banner
            //increase $
            //display cargo inventory and $ balance
            //present main menu
            //Travel Menu
            //present list of places to go
            //AC, EARTH
            //select speed (what cruise speed would you like to set in WF)
            //www.calormen.com/star_trek/warpcalc/  v(W) = W(10/3) ) + (10 − W)(-11/3)
            //CHANGE ship location
            //update location in banner
            //display message you traveled <> ly in <> (in time took)


        }

        void DispayMainMenu()
        {
            throw new NotImplementedException(); 
        }
        void ElicitUserInput()
        {
            throw new NotImplementedException();
        }

    }
}
