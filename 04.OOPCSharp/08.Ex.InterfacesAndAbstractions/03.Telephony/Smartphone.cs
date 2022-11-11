using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : ICall, IBrowsing
    {
        public string Browse(string site)
        {
            if (site.Any(x => int.TryParse(x.ToString(), out int result)))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {site}!";
        }

        public string Call(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                return "Invalid number!";
            }

            if (number.Length == 10) return $"Calling... {number}";

            return "Invalid number!";
        }
    }

}
