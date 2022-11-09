using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public abstract class Phone
    {

        public string Calling(string number)
        {
            if (number.Length==10)
            {
                return $"Calling... {number}";
            }
            else if(number.Length==7) return $"Dialing... {number}";

            return "Invalid number!";
        }
    }
}
