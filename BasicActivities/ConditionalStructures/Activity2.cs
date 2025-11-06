using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.ConditionalStructures
{
    public class Activity2
    {
        public static void GradeYourself()
        {
            double grade =-1;
            do
            {
                Console.WriteLine("Insert your grade: ");
                grade = Convert.ToDouble(Console.ReadLine());
            }while (grade < 0 || grade > 10);

            if (grade <5)
            {
                Console.WriteLine("Suspendido");
            }
            else if(grade >=5 && grade < 7)
            {
                Console.WriteLine("Aprobado");
            }
            else if(grade >=7 && grade < 9)
            {
                Console.WriteLine("Notable");
            }
            else
            {
                Console.WriteLine("Sobresaliente");
            }
        }
    }
}
