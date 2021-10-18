using System.IO;
using System;

namespace BatchedSort
{
    class FileReader
    {
        public string[] readFile(string file)
        {
            string[] numberValues = { };

            if (File.Exists(file))
            {
                numberValues = File.ReadAllLines(file);
            }

            return numberValues;
        }

        public string combinePaths(string fileToCombine)
        {
            var currentDir = Environment.CurrentDirectory;
            var fileCombined = Path.GetFullPath(Path.Combine(currentDir, "files", fileToCombine));
            return fileCombined;
        }
    }
}