using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            yeet();


        }

        private static void yeet()
        {
            Console.WriteLine("Skriv in ett datum (YYYY-MM-DD):");
            string date = Console.ReadLine();
            Console.WriteLine("Hur många månader backåt vill du gå?:");
            int amountOfMonths = int.Parse(Console.ReadLine());
            int year = int.Parse(date.Split('-')[0]);
            int month = int.Parse(date.Split('-')[1]);
            int day = int.Parse(date.Split('-')[2]);

            int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month > 12) yeet();
            if (day > monthDays[month - 1]) yeet();

            int daysPerYear = 365;
            int dayOfYear = 0;
            for (int i = 0; i < month; i++)
            {
                dayOfYear += monthDays[i];
            }
            daysPerYear += day;

            int targetMonth = month - amountOfMonths;
            if (targetMonth < 0)
            {
                if (amountOfMonths >= 12)
                {
                    while (amountOfMonths >= 12)
                    {
                        amountOfMonths -= 12;
                        year--;
                    }
                }
                else
                {
                    year--;
                }

                if (month > amountOfMonths) targetMonth = month - amountOfMonths;
                else targetMonth = monthDays.Length - (amountOfMonths - month);

            }

            string yeetMonth = $"0{targetMonth}";
            if (targetMonth >= 10) yeetMonth = targetMonth.ToString();
            Console.WriteLine(year + "-" + yeetMonth + "-" + day);
            yeet();
        }
    }
}
