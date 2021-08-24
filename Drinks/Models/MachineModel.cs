using Drinks.Data;
using System.Collections.Generic;
using Drinks.Business;
using System;

namespace Drinks.Models
{
    public class MachineModel
    {

        private List<DrinkSystem> drinks;
        private List<CoinSystem> coins;

        public MachineModel()
        {
            //All the drinks
            //New drinks can be added to this list to
            drinks = new List<DrinkSystem>
            {
                new Drink{Id=1, price=25, stock=5, name="Coke"},
                new Drink{Id=2, price=36, stock=15, name="Pepsi"},
                new Drink{Id=3, price=45, stock=3, name="Soda"},
            };

            //All the coins
            //New coins can be added to this list
            coins = new List<CoinSystem>
            {
                new Coin{Id=1, value=1, stock=100, name="Penny"},
                new Coin{Id=2, value=5, stock=10, name="Nickel"},
                new Coin{Id=3, value=10, stock=5, name="Dime"},
                new Coin{Id=3, value=25, stock=25, name="Quarter"},
            };

        }

        

    }
}
