using System;
using System.Collections.Generic;
using Drinks.Data;


namespace Drinks.Models
{
    public class MachineViewModel
    {
        /* This will receive the information that is relevant from the View*/
        public List<CoinSystem> InputCoins;
        public List<DrinkSystem> inputDrinks;

        public MachineViewModel()
        {
        }
    }
}
