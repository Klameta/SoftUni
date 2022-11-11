using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class Stationaryphone : ICall
    {
        public string Call(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                return "Invalid number!";
            }

            if (number.Length == 7) return $"Dialing... {number}";

            return "Invalid number!";
        }
    }
}
