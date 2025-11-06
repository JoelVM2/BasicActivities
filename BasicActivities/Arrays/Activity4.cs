using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.Arrays
{
    public class Activity4
    {
        public static void FilterEvenNumbers()
        {
            int[] numbers = new int[10];
            int[] evenNumbers = new int[10];
            int count = 0;
            Random randomNumber = new Random();

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = randomNumber.Next();
            }

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers[count++] = number;
                    Console.WriteLine($"{number} is and even number");
                }
            }
        }
    }
}

