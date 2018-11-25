using System.IO;
using System.Reflection;

namespace AdventOfCode2017.CSharp
{
    public static class Inputs
    {

        public static string Day1 => Inputs.GetDataFileText("day1.txt");

        public static string Day2 => Inputs.GetDataFileText("day2.txt");

        public const int Day3 = 312051;

        public static string Day4 => Inputs.GetDataFileText("day4.txt");

        public static string Day5 => Inputs.GetDataFileText("day5.txt");

        public static string Day6 => Inputs.GetDataFileText("day6.txt");

        public static string Day7 => Inputs.GetDataFileText("day7.txt");

        public static string Day8 => Inputs.GetDataFileText("day8.txt");

        public static string Day9 => Inputs.GetDataFileText("day9.txt");

        public static string Day10 => Inputs.GetDataFileText("day10.txt");

        public static string Day11 => Inputs.GetDataFileText("day11.txt");

        public static string Day12 => Inputs.GetDataFileText("day12.txt");

        public static string Day13 => Inputs.GetDataFileText("day13.txt");

        public const string Day14 = "ugkiagan";

        public const int Day15A = 722;
        public const int Day15B = 354;

        public static string Day16 => Inputs.GetDataFileText("day16.txt");

        public const int Day17 = 344;

        public static string Day18 => Inputs.GetDataFileText("day18.txt");

        public static string Day19 => Inputs.GetDataFileText("day19.txt");

        public static string Day20 => Inputs.GetDataFileText("day20.txt");

        public static string Day21 => Inputs.GetDataFileText("day21.txt");

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
