using System.IO;

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

        public string readLine(string file)
        {
            string line = "";

            if (File.Exists(file))
            {
                line = File.ReadLines(file).ToString();
            }

            return line;

        }

    }
}