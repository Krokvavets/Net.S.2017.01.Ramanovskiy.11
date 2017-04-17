using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    public static class BinarySearch<T>
    {
        /// <summary>
        /// Searches for an element by value
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="value">Input vlue</param>
        /// <param name="comarer">Exposes a method that compares two objects.</param>
        /// <returns>The first element that matches the conditions defined by value.</returns>
        public static int Search(T[] array, T value, IComparer<T> comarer)
        {
            if (array.Length == 0 || comarer.Compare(value, array[0]) < 0 || comarer.Compare(value, array[array.Length - 1]) > 0)
                return -1;
            int low = 0;
            int high = array.Length - 1;
            int middle;
            while (low <= high)
            {
                middle = (low + high) / 2;
                if (comarer.Compare(value, array[middle]) == 0) return middle;
                if (comarer.Compare(value, array[middle]) < 0) high = middle - 1;
                if (comarer.Compare(value, array[middle]) > 0) low = middle + 1;
            }
            return -1;
        }
    }
}
