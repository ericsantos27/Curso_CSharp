using System;

namespace Seção_7_Aula_86_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code with 'if and else'");
            Console.Write("Type the day: ");
            int x = int.Parse(Console.ReadLine());
            string day_x;

            if(x == 1)
            {
                day_x = "Sunday";
            }
            else if(x == 2)
            {
                day_x = "Monday";
            }
            else if(x == 3)
            {
                day_x = "Tuesday";
            }
            else if(x == 4)
            {
                day_x = "Wednesday";
            }
            else if(x == 5)
            {
                day_x = "Thursday";
            }
            else if(x == 6)
            {
                day_x = "Friday";
            }
            else if(x == 7)
            {
                day_x = "Saturday";
            }
            else
            {
                day_x = "Invalid day";
            }
            Console.WriteLine("Day = {0}", day_x);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Code with 'switch-case");
            Console.Write("Type the day: ");
            int y = int.Parse(Console.ReadLine());
            string day_y;

            switch(y)
            {
                case 1:
                    day_y = "Sunday";
                    break;
                case 2:
                    day_y = "Monday";
                    break;
                case 3:
                    day_y = "Tuesday";
                    break;
                case 4:
                    day_y = "Wednesday";
                    break;
                case 5:
                    day_y = "Thursday";
                    break;
                case 6:
                    day_y = "Friday";
                    break;
                case 7:
                    day_y = "Saturday";
                    break;
                default:
                    day_y = "Invalid day";
                    break;
            }
            Console.WriteLine("Day = {0}", day_y);
        }
    }
}
