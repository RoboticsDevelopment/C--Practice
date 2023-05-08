using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Speller
    {
        public static string Convert(int i)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>(){
            {0, "zero"},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"}
            };

            if (dic.ContainsKey(i))
                return dic[i];
            else
                return "nope";
        }

    }
}
