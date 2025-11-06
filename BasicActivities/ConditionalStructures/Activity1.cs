using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.ConditionalStructures
{
    public class Activity1
    {
        public static void AreYouAMinor()
        {
            int age;
            Console.WriteLine("Insert your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You are {(age < 18 ? "a minor." : "an adult.")}");
        }
    }
}
