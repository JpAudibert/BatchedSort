namespace Source
{
    class Program
    {
        private static readonly string file1 = "numbers-1.txt";
        private static readonly string file2 = "numbers-2.txt";
        private static readonly string fileOutput1 = "partial-1.txt";
        private static readonly string fileOutput2 = "partial-2.txt";
        static void Main(string[] args)
        {
            var fileReader = new FileReader();
            var fileWriter = new FileWriter();
            var sorter = new Sorter();

            var firstFile = PathCombiner.combineInputPaths(file1);
            var secondFile = PathCombiner.combineInputPaths(file2);

            var firstOutputFile = PathCombiner.combineOutputPaths(fileOutput1);
            var secondOutputFile = PathCombiner.combineOutputPaths(fileOutput2);

            var firstStringList = fileReader.readFile(firstFile);
            var secondStringList = fileReader.readFile(secondFile);

            var firstList = Parser.returnIntegerArray(firstStringList);
            var secondList = Parser.returnIntegerArray(secondStringList);

            firstList = sorter.quickSort(firstList);
            secondList = sorter.quickSort(secondList);

            var firstOutputList = Parser.returnStringArray(firstList);
            var secondOutputList = Parser.returnStringArray(secondList);

            fileWriter.writeFile(firstOutputList, firstOutputFile);
            fileWriter.writeFile(secondOutputList, secondOutputFile);
        }

    }
}
