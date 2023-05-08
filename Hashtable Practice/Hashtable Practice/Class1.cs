using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_Practice
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int GPA { get; set; }


        public Student(int ID, string name, int GPA)
        {
            this.ID = ID;
            this.Name = name;
            this. GPA = GPA;
        }

    }
}
