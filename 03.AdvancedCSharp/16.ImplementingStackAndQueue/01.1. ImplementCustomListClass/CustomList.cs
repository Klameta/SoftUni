using System;
using System.Collections.Generic;
using System.Text;

namespace _01._1._ImplementCustomListClass
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;

        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }

        public int Count { get; private set; }
    }
}
