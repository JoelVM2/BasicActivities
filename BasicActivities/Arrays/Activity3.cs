using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.Arrays
{
    public class Activity3
    {
        public static void FruitGuesser()
        {
            string[] fruits= {"apple","pineapple","banana","watermelon" };
            string userFruit;
            bool guessed = false;

            Console.WriteLine("Guess one of the fruits of the array: ");
            userFruit = Console.ReadLine().ToLower();

            foreach (var fruit in fruits)
            {
                if(fruit == userFruit)
                {
                    guessed = true;
                }
            }

            if (guessed)
            {
                Console.WriteLine($"Congratulations, your guess is correct, {userFruit} is in the array.");
            }
            else
            {
                Console.WriteLine($"Better luck next time, your guess {userFruit} is not in the array.");
            }
        }

    }
}

