using System;
using System.Collections;

namespace Hashtable_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();


            Student[] students = new Student[4];
            students[0] = new Student(1, "Patrick", 90);
            students[1] = new Student(2, "Ricky", 80);
            students[2] = new Student(1, "Patty", 50);
            students[3] = new Student(4, "Davis", 20);

            foreach(Student s in students)
            {
                if(!table.ContainsKey(s.ID))
                {
                    table.Add(s.ID, s);
                    Console.WriteLine("Student with ID:{0} has been added", s.ID);
                }
                else
                {
                    Console.WriteLine("Sorry student ID:{0} has already been added!", s.ID);
                }
            }
            Console.WriteLine();

            Console.WriteLine("The first students name is {0}, there ID:{2}, their GPA:{2}", ((Student)table[1]).Name, ((Student)table[1]).ID, ((Student)table[1]).GPA);
        }
    }
}
