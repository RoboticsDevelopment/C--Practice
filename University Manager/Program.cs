using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            Console.WriteLine();
            um.FemaleStudents();
            Console.WriteLine();
            um.SortStudentsByAge();
            Console.WriteLine();
            um.AllYaleStudents();
            Console.WriteLine();
            um.StudentAndUniversityNameCollection();
            Console.WriteLine();

            int[] someInts = { 30, 12, 4, 3, 69, 420, 88 };
            var sortedInts = from i in someInts orderby i select i;
            var reversedInts = sortedInts.Reverse();
            Console.WriteLine();
            Console.WriteLine("The hidden ints in reverse are: ");
            

            foreach (int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            foreach(int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            /*
            Console.WriteLine("Select a University to Query: 1 for Yale, 2 for Harvard");
            string input = Console.ReadLine();
            int inputAsInt = Convert.ToInt32(input);
            um.UniversityQuery(inputAsInt);

            Console.ReadKey();
            */

        }
    }
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        //CONSTRUCTOR
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //UNIVERSITIES
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Harvard" });

            //STUDENTS
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Patrick", Gender = "male", Age = 35, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Anna", Gender = "female", Age = 34, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Karen", Gender = "trans-gender", Age = 69, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Adolf", Gender = "male", Age = 88, UniversityId = 2 });
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection: ");

            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
            }




        }


        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students: ");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - Students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by Age");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllYaleStudents()
        {
            IEnumerable<Student> yaleStudents = from student in students
                                                join university in universities on student.UniversityId equals university.Id
                                                where university.Name == "Yale"
                                                select student;

            Console.WriteLine("Students attending Yale: ");
            foreach (Student student in yaleStudents)
            {
                student.Print();
            }
        }

        public void UniversityQuery(int Id)
        {
            IEnumerable<Student> myStudents = from student in students
                                              join university in universities on student.UniversityId equals university.Id
                                              where university.Id == Id
                                              select student;

            Console.WriteLine("Students from {0} University", Id);
            foreach(Student student in myStudents)
            {
                student.Print();
            }
        }

    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }


    class Student
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Gender { get; set; }
        public int Age { get; set; }
        //Foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2}" +
                " and Age {3} from University with the Id {4}", Name, Id, Gender, Age, UniversityId);
        }
    }

 
}
