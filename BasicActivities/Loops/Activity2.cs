using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.Loops
{
    public class Activity2
    {
        public static void MultiplicationTable()
        {
            int number;
            Console.WriteLine("Insert a number:");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {number} = " + (i * number));
            }
        }
    }
}
