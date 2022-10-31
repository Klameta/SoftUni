using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();
            var temp =  this[random.Next(0, this.Count - 1)];
            this.Remove(temp);
            return temp;
        }
    }
}
