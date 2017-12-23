using System.IO;
using System.Reflection;

namespace AdventOfCode2017.CSharp
{
    public static class Inputs
    {

        public static string Day1 => GetDataFileText("day1.txt");

        public static string Day2 => GetDataFileText("day2.txt");

        public const int Day3 = 312051;

        public static string Day4 => GetDataFileText("day4.txt");

        public static string Day5 => GetDataFileText("day5.txt");

        public static string Day6 => GetDataFileText("day6.txt");

        public static string Day7 => GetDataFileText("day7.txt");

        public static string Day8 => GetDataFileText("day8.txt");

        public static string Day9 => GetDataFileText("day9.txt");

        public static string Day10 => GetDataFileText("day10.txt");

        public static string Day11 => GetDataFileText("day11.txt");

        public static string Day12 => GetDataFileText("day12.txt");

        public static string Day13 => GetDataFileText("day13.txt");

        public const string Day14 = "ugkiagan";

        public const int Day15A = 722;
        public const int Day15B = 354;

        public static string Day16 => GetDataFileText("day16.txt");

        public const int Day17 = 344;

        public static string Day18 => GetDataFileText("day18.txt");

        public static string Day19 => GetDataFileText("day19.txt");

        private static string GetDataFileText(string filename)
        {
            return File.ReadAllText(Path.Combine(
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                "..",
                "..",
                "..",
                "..",
                filename));
        }

    }
}
