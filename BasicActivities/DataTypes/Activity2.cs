using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.DataTypes
{
    public class Activity1
    {
        public static void dataTypes()
        {
            int naturalNumber;
            double decimalNumber;
            char letter;
            bool stoplight;
            string phrase;

            Console.WriteLine("Insert a natural number: ");
            naturalNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a decimal number: ");
            decimalNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert a letter: ");
            letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Are you an idiot? (true/false)");
            stoplight = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Insert a short phrase: ");
            phrase = Console.ReadLine();

            Console.WriteLine($"Natural number: {naturalNumber}\nDecimal number: {decimalNumber}\nA letter: {letter}\nAre you?: {stoplight}\nPhrase: {phrase}");


        }
    }
}
