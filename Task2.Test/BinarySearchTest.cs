using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2.Test
{
    [TestFixture]
    public class BinarySearchTest
    {
        [TestCase(0, 1, 5, 4, 6, 1, 3, 87)]
        [TestCase(3, 5, 5, 4, 6, 1, 3, 87)]
        [TestCase(5, 87, 5, 4, 6, 1, 3, 87)]
        [TestCase(7, 11, 5, 4, 6, 1, 3, 87, 11, 2, 54, 7)]
        [Test]
        public void Serch_Positive_Test(int result, int value, params int[] array)
        {
            IComparer<int> comp = new IntComparer();
            Array.Sort(array);

            Assert.AreEqual(result, BinarySearch<int>.Search(array, value, comp));

        }
        private class IntComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x < y) return -1;
                if (x > y) return 1;
                return 0;
            }
        }
    }
}
