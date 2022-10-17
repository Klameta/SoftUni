using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _07.CustomComparator
{
    public class CustomComparator : IComparer<int>
    {
        public int Compare([AllowNull] int x, [AllowNull] int y)
        {
            if (x % 2 == 0 && Math.Abs(y) % 2 == 1)
                return -1;
            if (Math.Abs(x) % 2 == 1 && y % 2 == 0)
                return 1;
            return x.CompareTo(y);
        }
    }
}
