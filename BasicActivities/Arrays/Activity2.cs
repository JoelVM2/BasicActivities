using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.Arrays
{
    public class Activity2
    {
        public static void GreatNumber()
        {
            int[] numbers = new int[5];
            int biggerNumber = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insert a natural number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int number in numbers)
            {
                if(number > biggerNumber)
                {
                    biggerNumber = number;
                }   
            }

            Console.WriteLine($"The largest number is {biggerNumber}");
        }
    }
}
