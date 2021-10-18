using System.IO;
using System;
using System.Collections.Generic;

namespace Source
{
    class FileReader
    {
        private string[] readFile(string file)
        {
            string[] numberValues = { };

            if (File.Exists(file))
            {
                numberValues = File.ReadAllLines(file);
            }

            return numberValues;
        }

        public List<int> returnIntegerArray(string file)
        {
            var parsedArray = new List<int>();
            var stringArray = readFile(file);
            
            foreach (var item in stringArray)
            {
                parsedArray.Add(Int32.Parse(item));
            }

            return parsedArray;
        }

        public string combinePaths(string fileToCombine)
        {
            var currentDir = Environment.CurrentDirectory;
            var fileCombined = Path.GetFullPath(Path.Combine(currentDir, "files", fileToCombine));
            return fileCombined;
        }
    }
}