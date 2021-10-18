using System.IO;
using System;
using System.Collections.Generic;

namespace Source
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

    }
}