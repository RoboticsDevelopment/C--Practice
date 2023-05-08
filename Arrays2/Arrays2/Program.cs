using System;

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] jaggedArray2 = new int[][]
            {
                new int[] {2, 3, 4, 5,},
                new int[] {1, 2, 3, 4,}
            };

            Console.WriteLine(jaggedArray2[0][2]);

        }
    }
}
