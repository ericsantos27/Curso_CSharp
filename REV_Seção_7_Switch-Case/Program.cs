using System;

namespace REV_Seção_7_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numéric representation of the day: ");
            int dayNumb = int.Parse(Console.ReadLine());
            string day;
            Console.WriteLine();

            switch(dayNumb)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: {0}", day);

        }
    }
}
