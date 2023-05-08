using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersC
{
    internal class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;
        

        //member - public field
        public int age;


        //member - property - exposes jobTitle safely - properties start with a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} year old", memberName, jobTitle, age);
            }

        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        //member constructor
        public Members()
        {
            age = 19;
            memberName = "Anna";
            salary = 60000;
            jobTitle = "Toothologist";
            Console.WriteLine("Object created");
        }

        //member - finalizer - destructor
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Destruction of Members Object");
        }
    }
}
