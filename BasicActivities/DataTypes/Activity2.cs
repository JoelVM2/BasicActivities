using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.DataTypes
{
    public class Activity2
    {
        public static void TwoNumbers()
        {
            double firstNumber;
            double secondNumber;

            Console.WriteLine("Insert a number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert a second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The sum of the two numbers is {(firstNumber+secondNumber)}.\nThe substraction of the two numbers is {(firstNumber - secondNumber)}" +
                $".\nThe multiplication of the two numbers is {(firstNumber * secondNumber)}.\nThe division of the two numbers is {(firstNumber / secondNumber)}.\nThe rest of the two numbers is {(firstNumber % secondNumber)}.");

        }
    }
}
