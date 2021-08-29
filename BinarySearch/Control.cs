using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Control
    {
        public static void TestSearch(MyDelegate F, TestCase testCase)
        {
            try
            {
                var actual = F(testCase.InArray, testCase.N);
                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("ÏNVALID TEST");
                }
            }
            catch (Exception)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("ÏNVALID TEST");
                }
            }


        }
    }
}
    
