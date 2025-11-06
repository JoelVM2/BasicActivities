using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.DataTypes
{
    public class Activity3
    {
        public static void ConvertCelsius()
        {
            double celsius;

            Console.WriteLine("Insert a Celsius degrees: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{celsius} degrees Celsius are {((celsius*9/5)+32)} degrees Fahrenheit");
        }
    }
}
