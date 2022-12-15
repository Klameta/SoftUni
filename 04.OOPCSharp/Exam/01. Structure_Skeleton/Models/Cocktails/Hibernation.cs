using System;
using System.Collections.Generic;
using System.Text;
using ChristmasPastryShop.Models;
using ChristmasPastryShop.Utilities.Messages;
namespace ChristmasPastryShop.Models.Cocktails
{
    public class Hibernation : Cocktail
    {
        public Hibernation(string name, string size) : base(name, size, 15.75)
        {
        }
    }
}
