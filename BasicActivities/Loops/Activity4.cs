using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.Loops
{
    public class Activity4
    {
        public static void ShowNames()
        {
            string[] names = { "Juan", "Antonio", "Dario", "Manuel", "Pepe" };

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
