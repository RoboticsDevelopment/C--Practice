using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace LinqWithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string studentsXML =
                @"<Students>

                    <Student>
                        <Name>Toni</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <Race>White</Race>
                     </Student>

                     <Student>
                         <Name>Carla</Name>
                         <Age>17</Age>
                         <University>Harvard</University>
                         <Race>Asian</Race>
                     </Student>

                     <Student>
                         <Name>Ruby</Name>
                         <Age>69</Age>
                         <University>SPC</University>
                         <Race>Black</Race>
                     </Student>

                   </Students>";


            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Race = student.Element("Race").Value
                           };
            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} with Race {3}", student.Name, student.Age, student.University, student.Race);
            }

            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Student {0} with age {1} from University {2} with Race {3}", student.Name, student.Age, student.University, student.Race);
            }

            Console.ReadLine();

        }
    }
}
