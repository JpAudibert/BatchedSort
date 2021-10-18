using System.Collections.Generic;
using System.IO;

namespace Source
{
    class FileWriter
    {
        public void writeFile(List<string> list, string outputFile)
        {
            File.WriteAllLines(outputFile, list);
        }
    }
}