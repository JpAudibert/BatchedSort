using System;
using System.IO;

namespace Source
{
    class PathCombiner
    {
        public static string combineInputPaths(string fileToCombine)
        {
            var currentDir = Environment.CurrentDirectory;
            var fileCombined = Path.GetFullPath(Path.Combine(currentDir, "files", fileToCombine));
            return fileCombined;
        }

        public static string combineOutputPaths(string fileToCombine)
        {
            var currentDir = Environment.CurrentDirectory;
            var fileCombined = Path.GetFullPath(Path.Combine(currentDir, "output-files", fileToCombine));
            return fileCombined;
        }
    }
}