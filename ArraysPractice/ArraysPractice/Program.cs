using System;
using System.Runtime.Intrinsics.Arm;

namespace ArraysPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            string inputValueType;

            Console.WriteLine("Enter an Integer, String or Boolean");
            string inputValue = Console.ReadLine();


            Console.WriteLine("Select a Datatype to validate your input");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");


            Console.Write("Enter: ");
            int inputType = int.Parse(Console.ReadLine());


            switch (inputType)
            {
                case 1:
                    //check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;

                case 2:
                    //check for integer
                    int retValue = 0;
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;

                case 3:
                    //check for boolean
                    bool retFlag = false;
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;

                default:
                    inputValueType = "unknown";
                    Console.WriteLine("Not able to detect teh input type, something is wrong!");
                    break;
            }

            Console.WriteLine("You have entered a value: {0}", inputValue);
            if (valid)
            {
                Console.WriteLine("It is a valid {0}", inputValueType);
            }
            else
            {
                Console.WriteLine("It is an invalid {0}", inputValueType);
            }

        }

        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;



        }
    }
}
    
