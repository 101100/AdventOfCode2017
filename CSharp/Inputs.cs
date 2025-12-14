using System.IO;
using System.Reflection;

namespace AdventOfCode2017.CSharp
{
    public static class Inputs
    {

        public static string Day1 => Inputs.GetDataFileText("day01.txt");

        public static string Day2 => Inputs.GetDataFileText("day02.txt");

        public const int Day3 = 312051;

        public static string Day4 => Inputs.GetDataFileText("day04.txt");

        public static string Day5 => Inputs.GetDataFileText("day05.txt");

        public static string Day6 => Inputs.GetDataFileText("day06.txt");

        public static string Day7 => Inputs.GetDataFileText("day07.txt");

        public static string Day8 => Inputs.GetDataFileText("day08.txt");

        public static string Day9 => Inputs.GetDataFileText("day09.txt");

        public static string Day10 => Inputs.GetDataFileText("day10.txt");

        public static string Day11 => Inputs.GetDataFileText("day11.txt");

        public static string Day12 => Inputs.GetDataFileText("day12.txt");

        public static string Day13 => Inputs.GetDataFileText("day13.txt");

        public static string Day14 => Inputs.GetDataFileText("day14.txt");

        public const int Day15A = 722;
        public const int Day15B = 354;

        public static string Day16 => Inputs.GetDataFileText("day16.txt");

        public const int Day17 = 344;

        public static string Day18 => Inputs.GetDataFileText("day18.txt");

        public static string Day19 => Inputs.GetDataFileText("day19.txt");

        public static string Day20 => Inputs.GetDataFileText("day20.txt");

        public static string Day21 => Inputs.GetDataFileText("day21.txt");

        public static string Day22 => Inputs.GetDataFileText("day22.txt");

        public static string Day23 => Inputs.GetDataFileText("day23.txt");

        public static string Day24 => Inputs.GetDataFileText("day24.txt");

        public static string Day25 => Inputs.GetDataFileText("day25.txt");

        private static string GetDataFileText(string filename)
        {
            return File.ReadAllText(Path.Combine(
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                "..",
                "..",
                "..",
                "..",
                "inputs",
                filename));
        }

    }
}
