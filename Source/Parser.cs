using System;
using System.Collections.Generic;

namespace Source
{
    class Parser
    {
        public static List<int> returnIntegerArray(string[] stringArray)
        {
            var parsedArray = new List<int>();

            foreach (var item in stringArray)
            {
                parsedArray.Add(Int32.Parse(item));
            }

            return parsedArray;
        }

        public static List<string> returnStringArray(List<int> intArray)
        {
            var parsedArray = new List<string>();

            foreach (var item in intArray)
            {
                parsedArray.Add($"{item} ");
            }

            return parsedArray;
        }
    }
}