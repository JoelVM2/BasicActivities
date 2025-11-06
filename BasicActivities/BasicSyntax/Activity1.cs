using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.BasicSyntax
{
    public class Activity1
    {
        public static void ShowPersonalData()
        {
            string name;
            string age;
            string city;

            Console.WriteLine("Insert your name.");
            name = Console.ReadLine();
            Console.WriteLine("Insert your age.");
            age = Console.ReadLine();
            Console.WriteLine("Insert the city you live on.");
            city = Console.ReadLine();

            Console.WriteLine("Personla data: \nName: " +name +"\nAge: " + age + "\nCity: " + city);


        }
    }
}
