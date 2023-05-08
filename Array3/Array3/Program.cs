using System;
using System.Collections;

namespace Array3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hashtable studentsTable  = new Hashtable();

            Student stud1 = new Student(1, "Patrick", 98);
            Student stud2 = new Student(2, "Itlure", 92);
            Student stud3 = new Student(3, "Mommy", 94);
            Student stud4 = new Student(4, "Blahzy", 99);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            foreach(DictionaryEntry entry in studentsTable)
            {
                //Console.WriteLine(entry);
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}", temp.Id);
                Console.WriteLine("Student Name: {0}", temp.Name);
                Console.WriteLine("Student GPA: {0}", temp.GPA);


            }








        }


        class Student
        {

            //PROPERTIES
            public int Id { get; set; }

            public string Name { get; set; }

            public float GPA { get; set; }

            //constructor
            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this.GPA = GPA;
            }
        }


    }
}

