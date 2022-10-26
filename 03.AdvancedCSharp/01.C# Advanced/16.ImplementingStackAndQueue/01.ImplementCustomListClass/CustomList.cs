using System;

namespace _01.ImplementCustomListClass
{
    public class CustomList
    {
        int[] items;
        private const int InitialCapacity = 4;
        private int lenght = InitialCapacity;
        public int Count = 0;
        public CustomList()
        {
            items = new int[InitialCapacity];
        }

        public void Add(int element)
        {
            if (Count + 1 >= lenght)
            {
                items = Resize();
            }
            items[Count + 1] = element;
            Count++;
        }

        internal int[] Resize()
        {
            lenght *= 2;
            int[] newArr = new int[lenght];
            for (int i = 0; i < items.Length; i++)
            {
                newArr[i] = items[i];
            }
            return newArr;
        }
    }
}
