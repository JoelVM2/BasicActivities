using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.Loops
{
    public class Activity3
    {
        public static void NegativeSearch()
        {
            int number;
            int count = 0;
            do
            {
                Console.WriteLine("Insert a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                count++;
            } while (number >=0);

            Console.WriteLine($"You introduced {(count-1)} positive numbers.");
        }
    }
}
