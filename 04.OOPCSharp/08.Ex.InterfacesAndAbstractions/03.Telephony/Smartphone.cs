using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : Phone
    {
        public string Browse(string site)
        {
            if (site.Any(x => int.TryParse(x.ToString(),out int result)))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {site}!";
        }
    }

}
