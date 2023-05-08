using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes__Basics3
{
    // this class is a blueprint for a datatype
     class Human
    {
        //member variable
        private string firstName = null;   //make public to use everywhere!
        private string lastName = null;
        private string eyeColor = null;
        private int age = 0;
        
        //default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created!");
        }
        //parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
           
        }
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
           
        }
        //member method
        public void IntroduceMyself()
        {
            if(age != 0 && lastName != null && eyeColor != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1} and I'm {2} years old. My eye color is {3}", firstName, lastName, age, eyeColor); 
            else if (eyeColor != null && lastName != null & firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}", firstName, lastName, eyeColor);
            }
            else if (age != 0  && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}. My age is {2}", firstName, lastName, age);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
            }
        }
            

        




    }
}
