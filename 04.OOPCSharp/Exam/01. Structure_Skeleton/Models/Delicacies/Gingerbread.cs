using System;
using System.Collections.Generic;
using System.Text;
using ChristmasPastryShop.Models;
using ChristmasPastryShop.Utilities.Messages;

namespace ChristmasPastryShop.Models.Delicacies
{
    public class Gingerbread : Delicacy
    {
        public Gingerbread(string delicacyName) : base(delicacyName, 4.00)
        {
        }
    }
}
