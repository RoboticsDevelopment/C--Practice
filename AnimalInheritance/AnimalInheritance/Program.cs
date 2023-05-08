using System;

namespace AnimalInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Rex", 15);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.Play();
            dog.Eat();

        }
    }
}
