using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.BasicSyntax
{
    public class Activity2
    {
        public static void totalPrice()
        {
            string cider;
            string price;


            Console.WriteLine("How much does the cider cost?");
            price = Console.ReadLine();
            Console.WriteLine("How many cider cans are you going to take?");
            cider = Console.ReadLine();

            double totalPrice = (Convert.ToDouble(price) * Convert.ToDouble(cider));

            Console.WriteLine($"Every cider costs {price}€ and you have {cider} ciders, the total you have to pay is {totalPrice}€.");
        }
    }
}
