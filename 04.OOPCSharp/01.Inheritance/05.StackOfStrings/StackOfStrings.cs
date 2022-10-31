using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this == null;
        }

        public Stack<string> AddRange(IEnumerable<string> collection)
        {
            foreach (var str in collection)
            {
                this.Push(str);
            }

            return this;
        }
    }
}
