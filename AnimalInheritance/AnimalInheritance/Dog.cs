using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    internal class Dog : Animal
    {

        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            base.MakeSound();
            {
                Console.WriteLine("Wuuuf!");
            }

        }

        public override void Play()
        {
            if(IsHappy)
            {
                base.Play();
            }
        }
    }
}
