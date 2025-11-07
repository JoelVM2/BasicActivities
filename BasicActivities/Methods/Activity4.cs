using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.Methods
{
    public class Activity4
    {
        public static Double Average(double[] notas)
        {
            double average = 0;
            foreach (var nota in notas)
            {
                average += nota;
            }

            return average/notas.Length;
        }
    }
}
