using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Delegates
{
    internal class Program
    {


        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {

            Person p1 = new Person() { Name = "Patrick", Age = 35 };
            Person p2 = new Person() { Name = "Adolf", Age = 88 };
            Person p3 = new Person() { Name = "Panda", Age = 6 };
            Person p4 = new Person() { Name = "Senior", Age = 99 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);

        }

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach(Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
        }

        // FILTERS

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18  && p.Age < 65;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}
