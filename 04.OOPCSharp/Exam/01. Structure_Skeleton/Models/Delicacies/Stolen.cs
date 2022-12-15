using System;
using System.Collections.Generic;
using System.Text;
using ChristmasPastryShop.Models;
using ChristmasPastryShop.Utilities.Messages;
namespace ChristmasPastryShop.Models.Delicacies
{
    public class Stolen : Delicacy
    {
        public Stolen(string delicacyName) : base(delicacyName, 3.50)
        {
        }
    }
}
