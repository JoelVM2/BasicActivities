using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicActivities.ConditionalStructures
{
    public class Activity3
    {
        public static void WeekDay()
        {
            int weekDay;
            do
            {
                Console.WriteLine("Insert a number of the week: ");
                weekDay = Convert.ToInt16(Console.ReadLine());
            }while (weekDay < 1 || weekDay >7);

            switch (weekDay)
            {
                case 1:
                    ShowMsg("Monday", weekDay);
                    break;
                case 2:
                    ShowMsg("Tuesday", weekDay);
                    break;
                case 3:
                    ShowMsg("Wednesday", weekDay);
                    break;
                case 4:
                    ShowMsg("Thursday", weekDay);
                    break;
                case 5:
                    ShowMsg("Friday", weekDay);
                    break;
                case 6:
                    ShowMsg("Saturday", weekDay);
                    break;
                default:
                    ShowMsg("Sunday", weekDay);
                    break;
            }

        }
        public static void ShowMsg(string msg, double weekDay)
        {
            Console.WriteLine($"The number of the week {weekDay} corresponds to {msg}");
        }
    }

    }
