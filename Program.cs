using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace AdventOfCode2017
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var dayString = args.Length >= 1
                ? args[0]
                : ReadDay();

            if (!byte.TryParse(dayString, out var day))
            {
                Console.WriteLine($"I've never heard of day '{dayString}', sorry.");
                return;
            }

            if (day == 1)
            {
                const string input = Inputs.Day1;

                Console.WriteLine($"Part 1: {Day1Part1(input)}");
                Console.WriteLine($"Part 2: {Day1Part2(input)}");
            }
            else if (day == 2)
            {
                const string input = Inputs.Day2;

                Console.WriteLine($"Part 1: {Day2Part1(input)}");
                Console.WriteLine($"Part 2: {Day2Part2(input)}");
            }
            else if (day == 3)
            {
                var input = GetIntInput(args) ?? Inputs.Day3;

                Console.WriteLine($"Part 1: {Day3Part1(input)}");
                Console.WriteLine($"Part 2: {Day3Part2(input)}");
            }
            else if (day == 4)
            {
                var input = Inputs.Day4;

                Console.WriteLine($"Part 1: {Day4Part1(input)}");
                Console.WriteLine($"Part 2: {Day4Part2(input)}");
            }
            else
            {
                Console.WriteLine($"I've never heard of day '{day}', sorry.");
            }
        }

        private static string ReadDay()
        {
            Console.Write("Run what day: ");
            return Console.ReadLine();
        }

        private static int? GetIntInput(string[] args)
        {
            return args.Length >= 2
                ? int.Parse(args[1])
                : default(int?);
        }

        private static int Day1Part1(string input)
        {
            return input
                .StartWith(input.Last())
                .PairWise()
                .Aggregate(0, (sum, t) => t.Item1 == t.Item2 ? sum + (t.Item1 - '0') : sum);
        }

        private static int Day1Part2(string input)
        {
            var halfLength = input.Length / 2;

            return 2 * input.Take(halfLength)
                .Zip(input.Skip(halfLength), Tuple.Create)
                .Aggregate(0, (sum, t) => t.Item1 == t.Item2 ? sum + (t.Item1 - '0') : sum);
        }

        private static int Day2Part1(string input)
        {
            return input
                .Split("\n")
                .Select(r => r.Trim())
                .Select(row => row
                    .Split("\t")
                    .Select(int.Parse)
                    .ToArray())
                .Select(row => row.Aggregate(0, Math.Max) - row.Aggregate(int.MaxValue, Math.Min))
                .Aggregate(0, (a, b) => a + b);
        }

        private static int Day2Part2(string input)
        {
            return input
                .Split("\n")
                .Select(r => r.Trim())
                .Select(row => row
                    .Split("\t")
                    .Select(int.Parse)
                    .ToArray())
                .Select(row => row
                    .AllPairs()
                    .Where(t => t.Item1 > t.Item2 ? t.Item1 % t.Item2 == 0 : t.Item2 % t.Item1 == 0)
                    .Select(t => t.Item1 > t.Item2 ? t.Item1 / t.Item2 : t.Item2 / t.Item1)
                    .First())
                .Aggregate(0, (a, b) => a + b);
        }

        private static int Day3Part1(int input)
        {
            if (input == 1)
            {
                return 0;
            }

            var ring = (((int) Math.Sqrt(input - 1)) + 1) / 2;

            var offset = ((ring - 1) * 2 + 1) * ((ring - 1) * 2 + 1) + 1;
            var sideLength = ring * 2;
            var middleIndex = ring - 1;

            var circularIndex = input - offset;

            return ring + Math.Abs((circularIndex % sideLength) - middleIndex);
        }

        private static int Day3Part2(int input)
        {
            return EnumerableExtensions
                .Generate(new [] { 1 }.ToImmutableList(), _ => true, last =>
                {
                    var nextPoint = Day3ToPoint(last.Count + 1);
                    var nextValue = Day3GetNeighbours(nextPoint)
                        .Select(Day3FromPoint)
                        .Select(v => last.Count > v - 1 ? last[v - 1] : 0)
                        .Aggregate(0, (a, b) => a + b);

                    return last.Add(nextValue);
                })
                .Skip(1)
                .Select(l => l.Last())
                .SkipWhile(value => value < input)
                .First();
        }

        private static IEnumerable<Tuple<int, int>> Day3GetNeighbours(Tuple<int, int> point)
        {
            yield return Tuple.Create(point.Item1 + 1, point.Item2 + 1);
            yield return Tuple.Create(point.Item1 + 1, point.Item2);
            yield return Tuple.Create(point.Item1 + 1, point.Item2 - 1);
            yield return Tuple.Create(point.Item1, point.Item2 + 1);
            yield return Tuple.Create(point.Item1, point.Item2 - 1);
            yield return Tuple.Create(point.Item1 - 1, point.Item2 + 1);
            yield return Tuple.Create(point.Item1 - 1, point.Item2);
            yield return Tuple.Create(point.Item1 - 1, point.Item2 - 1);
        }

        private static Tuple<int, int> Day3ToPoint(int input)
        {
            if (input == 1)
            {
                return Tuple.Create(0, 0);
            }

            var ring = (((int) Math.Sqrt(input - 1)) + 1) / 2;

            var offset = ((ring - 1) * 2 + 1) * ((ring - 1) * 2 + 1) + 1;
            var sideLength = ring * 2;
            var middleIndex = ring - 1;

            var circularIndex = input - offset;

            var sideIndex = (circularIndex % sideLength) - middleIndex;

            var quadrant = circularIndex / sideLength;
            var x = quadrant == 0 ? ring
                : quadrant == 1 ? -sideIndex
                : quadrant == 2 ? -ring
                : sideIndex;
            var y = quadrant == 0 ? sideIndex
                : quadrant == 1 ? ring
                : quadrant == 2 ? -sideIndex
                : -ring;

            return Tuple.Create(x, y);
        }

        private static int Day3FromPoint(Tuple<int, int> point)
        {
            var x = point.Item1;
            var y = point.Item2;

            if (x == 0 && y == 0)
            {
                return 1;
            }

            var ring = Math.Max(Math.Abs(x), Math.Abs(y));
            var sideLength = ring * 2;
            var middleIndex = ring - 1;

            var quadrant = x == ring && y < ring ? 0
                : y == ring && x > -ring ? 1
                : x == -ring && y > -ring ? 2
                : 3;

            var sideIndex = quadrant == 0 ? y + middleIndex
                : quadrant == 1 ? middleIndex - x
                : quadrant == 2 ? middleIndex - y
                : x + middleIndex;
            var circularIndex = sideIndex + sideLength * quadrant;

            if (circularIndex < 0)
            {
                circularIndex = circularIndex + sideLength * 4;
            }

            var offset = ((ring - 1) * 2 + 1) * ((ring - 1) * 2 + 1) + 1;

            return circularIndex + offset;
        }

        private static int Day4Part1(string input)
        {
            return input
                .Split("\n")
                .Select(r => r.Trim())
                .Select(row => row
                    .Split(" ")
                    .ToArray())
                .Select(row => row
                    .GroupBy(s => s)
                    .Where(g => g.Count() > 1)
                    .Any())
                .Where(invalid => !invalid)
                .Count();
        }

        private static int Day4Part2(string input)
        {
            return input
                .Split("\n")
                .Select(r => r.Trim())
                .Select(row => row
                    .Split(" ")
                    .ToArray())
                .Select(row => row
                    .GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
                    .Where(g => g.Count() > 1)
                    .Any())
                .Where(invalid => !invalid)
                .Count();
        }

    }
}
