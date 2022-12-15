using System;
using System.Collections.Generic;
using System.Text;
using ChristmasPastryShop.Models;
using ChristmasPastryShop.Utilities.Messages;

namespace ChristmasPastryShop.Models.Cocktails
{
    public class MulledWine : Cocktail
    {
        public MulledWine(string name, string size) : base(name, size, 20.25)
        {
        }
    }
}
