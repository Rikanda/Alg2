using System;

namespace BinarySearch
{
    delegate int MyDelegate(int[] inputArray, int searchValue);
    class Program
    {
        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                InArray = new int[] {1, 6, 77, 123, 456, 574, 689},
                N = 77,
                Expected = 2,
                ExpectedException = null

            };

            var testCase2 = new TestCase()
            {
                InArray = new int[] { 1, 6, 77, 123, 456, 574, 689 },
                N = 80,
                Expected = -1,
                ExpectedException = null

            };

            Control.TestSearch(BinarySearch.bSearch, testCase1);
            Control.TestSearch(BinarySearch.bSearch, testCase2);

        }
    }

       
        
}
