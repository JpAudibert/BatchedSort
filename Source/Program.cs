using System;
using System.IO;

namespace Source
{
    class Program
    {
        private static readonly string file1 = "numbers-1.txt";
        private static readonly string file2 = "numbers-2.txt";
        static void Main(string[] args)
        {
            var fileReader = new FileReader();
            var firstFile = fileReader.combinePaths(file1);
            var secondFile = fileReader.combinePaths(file2);

            var firstList = fileReader.readFile(firstFile);
            
        }

        
    }
}
