using System;
namespace Drinks.Data
{
    public abstract class CoinSystem
    {
        public int Id;
        public int value; //Value in cents
        public int stock; //Amount of particular coins inside the machine
        public string name; //Coin name
    }
}