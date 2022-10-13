using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] array = new T[length];
            array = array.Select(x => x = item)
                .ToArray();

            return array;
        }
    }
}
