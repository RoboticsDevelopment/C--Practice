using System;

namespace DateTimeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime patsBday = new DateTime(1987, 5, 21);
            Console.WriteLine("Pats birthday is {0}", patsBday);

            DateTime today =  DateTime.Today;
            Console.WriteLine("Todays Date is: {0}", today);

            DateTime now = DateTime.Now;
            Console.WriteLine("Right now it's: {0}", DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the {0}", tomorrow);

            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);

            

            Console.WriteLine("Minute {0}", now.Minute);
            DateTime dateTime = new DateTime();

            Console.WriteLine("Write your Birthday in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("You've been alive for {0} days :)", daysPassed.Days);
            }else
            {
                Console.WriteLine("Wrong Input");
            }


            static DateTime GetTomorrow()
            {
                return DateTime.Today.AddDays(1);
            }

            static DateTime firstDayOfYear(int year)
            {
                return new DateTime(year, 1, 1);
            }


        }
    }
}
