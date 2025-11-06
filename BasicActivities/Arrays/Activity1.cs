using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.Arrays
{
    public class Activity1
    {
        public static void ArraySum()
        {
            int[] numbers= {6,8,23,5,12};
            int result =0;

            foreach (var number in numbers)
            {
                result += number;
            }

            Console.WriteLine($"The sum of all the numbers in the array is {result}");


        }
    }
}
