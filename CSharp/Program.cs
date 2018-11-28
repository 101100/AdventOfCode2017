using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;

using AdventOfCode2017.FSharp;

namespace AdventOfCode2017.CSharp
{
    public static class Program
    {

        private static void Main(string[] args)
        {
            var dayString = args.Length >= 1
                ? args[0]
                : Program.ReadDay();

            if (!byte.TryParse(dayString, out var day))
            {
                Console.WriteLine($"I've never heard of day '{dayString}', sorry.");
                return;
            }

            if (day == 1)
            {
                var input = Inputs.Day1;

                Console.WriteLine($"Part 1 (C#): {Program.Day1Part1(input)}");
                Console.WriteLine($"Part 1 (F#): {Day1.part1(input)}");
                Console.WriteLine($"Part 2 (C#): {Program.Day1Part2(input)}");
                Console.WriteLine($"Part 2 (F#): {Day1.part2(input)}");
            }
            else if (day == 2)
            {
                var input = Inputs.Day2;

                Console.WriteLine($"Part 1: {Program.Day2Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day2Part2(input)}");
            }
            else if (day == 3)
            {
                var input = Program.GetIntInput(args) ?? Inputs.Day3;

                Console.WriteLine($"Part 1: {Program.Day3Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day3Part2(input)}");
            }
            else if (day == 4)
            {
                var input = Inputs.Day4;

                Console.WriteLine($"Part 1: {Program.Day4Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day4Part2(input)}");
            }
            else if (day == 5)
            {
                var input = Inputs.Day5;

                Console.WriteLine($"Part 1: {Program.Day5Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day5Part2(input)}");
            }
            else if (day == 6)
            {
                var input = Inputs.Day6;

                Console.WriteLine($"Part 1: {Program.Day6Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day6Part2(input)}");
            }
            else if (day == 7)
            {
                var input = Inputs.Day7;

                Console.WriteLine($"Part 1: {Program.Day7Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day7Part2(input)}");
            }
            else if (day == 8)
            {
                var input = Inputs.Day8;

                Console.WriteLine($"Part 1: {Program.Day8Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day8Part2(input)}");
            }
            else if (day == 9)
            {
                var input = Inputs.Day9;

                Console.WriteLine($"Part 1: {Program.Day9Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day9Part2(input)}");
            }
            else if (day == 10)
            {
                var input = Inputs.Day10;

                Console.WriteLine($"Part 1: {Program.Day10Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day10Part2(input)}");
            }
            else if (day == 11)
            {
                var input = Inputs.Day11;

                Console.WriteLine($"Part 1: {Program.Day11Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day11Part2(input)}");
            }
            else if (day == 12)
            {
                var input = Inputs.Day12;

                Console.WriteLine($"Part 1: {Program.Day12Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day12Part2(input)}");
            }
            else if (day == 13)
            {
                var input = Inputs.Day13;

                Console.WriteLine($"Part 1: {Program.Day13Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day13Part2(input)}");
            }
            else if (day == 14)
            {
                var input = Inputs.Day14;

                Console.WriteLine($"Part 1: {Program.Day14Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day14Part2(input)}");
            }
            else if (day == 15)
            {
                var inputA = Inputs.Day15A;
                var inputB = Inputs.Day15B;

                Console.WriteLine($"Part 1: {Program.Day15Part1(inputA, inputB)}");
                Console.WriteLine($"Part 2: {Program.Day15Part2(inputA, inputB)}");
            }
            else if (day == 16)
            {
                var input = Inputs.Day16;

                Console.WriteLine($"Part 1: {Program.Day16Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day16Part2(input)}");
            }
            else if (day == 17)
            {
                var input = Program.GetIntInput(args) ?? Inputs.Day17;

                Console.WriteLine($"Part 1: {Program.Day17Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day17Part2(input)}");
            }
            else if (day == 18)
            {
                var input = Inputs.Day18;

                Console.WriteLine($"Part 1: {Program.Day18Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day18Part2(input)}");
            }
            else if (day == 19)
            {
                var input = Inputs.Day19;

                Console.WriteLine($"Part 1: {Program.Day19Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day19Part2(input)}");
            }
            else if (day == 20)
            {
                var input = Inputs.Day20;

                Console.WriteLine($"Part 1: {Program.Day20Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day20Part2(input)}");
            }
            else if (day == 21)
            {
                var input = Inputs.Day21;

                Console.WriteLine($"Part 1: {Program.Day21Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day21Part2(input)}");
            }
            else if (day == 22)
            {
                var input = Inputs.Day22;

                Console.WriteLine($"Part 1: {Program.Day22Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day22Part2(input)}");
            }
            else if (day == 23)
            {
                var input = Inputs.Day23;

                Console.WriteLine($"Part 1: {Program.Day23Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day23Part2(input)}");
            }
            else if (day == 24)
            {
                var input = Inputs.Day24;

                Console.WriteLine($"Part 1: {Program.Day24Part1(input)}");
                Console.WriteLine($"Part 2: {Program.Day24Part2(input)}");
            }
            else if (day == 25)
            {
                var input = Inputs.Day25;

                Console.WriteLine($"Part 1: {Program.Day25Part1(input)}");
                // There is no part 2!
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
                .SelectLines()
                .Select(row => row
                    .Split("\t")
                    .Select(int.Parse)
                    .ToArray())
                .Select(row => row.Max() - row.Min())
                .Sum();
        }

        private static int Day2Part2(string input)
        {
            return input
                .SelectLines()
                .Select(row => row
                    .Split("\t")
                    .Select(int.Parse)
                    .ToArray())
                .Select(row => row
                    .AllPairs()
                    .Where(t => t.Item1 > t.Item2 ? t.Item1 % t.Item2 == 0 : t.Item2 % t.Item1 == 0)
                    .Select(t => t.Item1 > t.Item2 ? t.Item1 / t.Item2 : t.Item2 / t.Item1)
                    .First())
                .Sum();
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
                    var nextPoint = Program.Day3ToPoint(last.Count + 1);
                    var nextValue = Program.Day3GetNeighbours(nextPoint)
                        .Select(Program.Day3FromPoint)
                        .Select(v => last.Count > v - 1 ? last[v - 1] : 0)
                        .Sum();

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
                .SelectLines()
                .Select(row => row
                    .Split(" ")
                    .ToArray())
                .Select(row => row
                    .GroupBy(s => s)
                    .Any(g => g.Count() > 1))
                .Count(invalid => !invalid);
        }

        private static int Day4Part2(string input)
        {
            return input
                .SelectLines()
                .Select(row => row
                    .Split(" ")
                    .ToArray())
                .Select(row => row
                    .GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
                    .Any(g => g.Count() > 1))
                .Count(invalid => !invalid);
        }

        private static int Day5Part1(string input)
        {
            var startingCode = input
                .SelectLines()
                .Select(int.Parse)
                .ToImmutableList();

            return EnumerableExtensions
                .Generate(Tuple.Create(startingCode, 0),
                    state => state.Item2 >= 0 && state.Item2 < state.Item1.Count,
                    lastState => Tuple.Create(
                        lastState.Item1.SetItem(lastState.Item2, lastState.Item1[lastState.Item2] + 1),
                        lastState.Item2 + lastState.Item1[lastState.Item2]))
                .Count();
        }

        private static int Day5Part2(string input)
        {
            var startingCode = input
                .SelectLines()
                .Select(int.Parse)
                .ToImmutableList();

            return EnumerableExtensions
                .Generate(Tuple.Create(startingCode, 0),
                    state => state.Item2 >= 0 && state.Item2 < state.Item1.Count,
                    lastState => Tuple.Create(
                        lastState.Item1.SetItem(lastState.Item2, lastState.Item1[lastState.Item2] >= 3 ? lastState.Item1[lastState.Item2] - 1 : lastState.Item1[lastState.Item2] + 1),
                        lastState.Item2 + lastState.Item1[lastState.Item2]))
                .Count();
        }

        private static int Day6Part1(string input)
        {
            var startingState = input
                .Split("\t")
                .Select(int.Parse)
                .ToImmutableList();

            return EnumerableExtensions
                .Generate(Tuple.Create(ImmutableHashSet<string>.Empty, startingState),
                    state => !state.Item1.Contains(string.Join(":", state.Item2)),
                    lastState => Tuple.Create(lastState.Item1.Add(string.Join(":", lastState.Item2)), Program.Day6Redistribute(lastState.Item2)))
                .Count();
        }

        private static int Day6Part2(string input)
        {
            var startingState = input
                .Split("\t")
                .Select(int.Parse)
                .ToImmutableList();

            return EnumerableExtensions
                .Generate(Tuple.Create(ImmutableDictionary<string, int>.Empty, startingState),
                    state => state.Item1.All(p => p.Value <= 1),
                    lastState => Tuple.Create(lastState.Item1.SetItem(string.Join(":", lastState.Item2), lastState.Item1.GetValueOrDefault(string.Join(":", lastState.Item2), 0) + 1), Program.Day6Redistribute(lastState.Item2)))
                .Select((t, index) => Tuple.Create(string.Join(":", t.Item2), index))
                .Aggregate(ImmutableDictionary<string, ImmutableList<int>>.Empty,
                    (acc, tuple) => acc.UpdateValue( tuple.Item1, ImmutableList<int>.Empty, list => list.Add(tuple.Item2)))
                .Select(p => p.Value)
                .Where(l => l.Count > 1)
                .Select(l => l[1] - l[0])
                .First();
        }

        private static ImmutableList<int> Day6Redistribute(ImmutableList<int> lastState)
        {
            var maxIndex = lastState
                .Select((amount, index) => Tuple.Create(amount, index))
                .OrderByDescending(t => t.Item1)
                .ThenBy(t => t.Item2)
                .First()
                .Item2;

            var amountToRedistribute = lastState[maxIndex];
            var amountPerBank = amountToRedistribute / lastState.Count;
            var extra = amountToRedistribute % lastState.Count;

            return lastState
                .Select((amount, index) => amountPerBank
                    + (index > maxIndex && maxIndex + extra >= index ? 1 : 0)
                    + (index <= maxIndex && index <= maxIndex + extra - lastState.Count ? 1 : 0)
                    + (index == maxIndex ? 0 : amount))
                .ToImmutableList();
        }

        private static string Day7Part1(string input)
        {
            var inputs = input
                .SelectLines()
                .Select(line => line.Split(" "))
                .Select(parts => Tuple.Create(
                    parts[0],
                    int.Parse(parts[1].Trim('(', ')')),
                    parts.Length > 3
                        ? parts
                            .Skip(3)
                            .Select(s => s.TrimEnd(','))
                            .ToImmutableArray()
                        : ImmutableArray<string>.Empty))
                .ToImmutableDictionary(tuple => tuple.Item1);

            return inputs
                .Select(p => p.Key)
                .ToImmutableHashSet()
                .Except(inputs.SelectMany(p => p.Value.Item3))
                .First();
        }

        private static int Day7Part2(string input)
        {
            var inputs = input
                .SelectLines()
                .Select(line => line.Split(" "))
                .Select(parts => Tuple.Create(
                    parts[0],
                    int.Parse(parts[1].Trim('(', ')')),
                    parts.Length > 3
                        ? parts
                            .Skip(3)
                            .Select(s => s.TrimEnd(','))
                            .ToImmutableArray()
                        : ImmutableArray<string>.Empty))
                .ToImmutableDictionary(tuple => tuple.Item1);

            var rootName = inputs
                .Select(p => p.Key)
                .ToImmutableHashSet()
                .Except(inputs.SelectMany(p => p.Value.Item3))
                .First();

            var root = rootName.Day7BuildTree(inputs);

            return Program.Day7FindUnbalancedNodesCorrectWeight(root);
        }

        private class TreeNode
        {
            public string Name;
            public int Weight;
            public ImmutableArray<TreeNode> Children;
            public int ChildrenWeight;
            public int TotalWeight;
        }

        private static TreeNode Day7BuildTree(this string rootName,
            ImmutableDictionary<string, Tuple<string, int, ImmutableArray<string>>> inputs)
        {
            var rootInfo = inputs[rootName];

            var root = new TreeNode
            {
                Name = rootName,
                Weight = rootInfo.Item2,
                Children = rootInfo.Item3
                    .Select(childName => childName.Day7BuildTree(inputs))
                    .ToImmutableArray()
            };

            root.ChildrenWeight = root.Children.Sum(child => child.TotalWeight);
            root.TotalWeight = root.Weight + root.ChildrenWeight;

            return root;
        }

        private static int Day7FindUnbalancedNodesCorrectWeight(TreeNode root)
        {
            foreach (var child in root.Children)
            {
                var result = Program.Day7FindUnbalancedNodesCorrectWeight(child);
                if (result > 0)
                {
                    return result;
                }
            }

            var childWeights = root.Children
                .GroupBy(child => child.TotalWeight)
                .ToImmutableDictionary(g => g.Key, g => g.Count());

            if (childWeights.Count > 1)
            {
                var correctWeight = childWeights
                    .OrderByDescending(w => w.Value)
                    .Select(p => p.Key)
                    .First();

                var badChild = root.Children
                    .First(child => child.TotalWeight != correctWeight);

                return correctWeight - badChild.ChildrenWeight;
            }

            return -1;
        }

        private static int Day8Part1(string input)
        {
            return input
                .SelectLines()
                .Select(line => line.Split(" "))
                .Select(parts => Tuple.Create(
                    parts[0],
                    int.Parse(parts[2]) * (string.Equals("inc", parts[1], StringComparison.OrdinalIgnoreCase) ? 1 : -1),
                    parts[4],
                    parts[5],
                    int.Parse(parts[6])))
                .Aggregate(ImmutableDictionary<string, int>.Empty,
                    (registers, parsed) =>
                    {
                        return Program.Day8CheckCondition(registers.GetValueOrDefault(parsed.Item3, 0), parsed.Item4, parsed.Item5)
                            ? registers.UpdateValue(parsed.Item1, 0, val => val + parsed.Item2)
                            : registers;
                    })
                .Select(p => p.Value)
                .Max();
        }

        private static int Day8Part2(string input)
        {
            return input
                .SelectLines()
                .Select(line => line.Split(" "))
                .Select(parts => Tuple.Create(
                    parts[0],
                    int.Parse(parts[2]) * (string.Equals("inc", parts[1], StringComparison.OrdinalIgnoreCase) ? 1 : -1),
                    parts[4],
                    parts[5],
                    int.Parse(parts[6])))
                .Scan(ImmutableDictionary<string, int>.Empty,
                    (registers, parsed) =>
                    {
                        return Program.Day8CheckCondition(registers.GetValueOrDefault(parsed.Item3, 0), parsed.Item4, parsed.Item5)
                            ? registers.UpdateValue(parsed.Item1, 0, val => val + parsed.Item2)
                            : registers;
                    })
                .Select(r => r
                    .Select(p => p.Value)
                    .Max())
                .Max();
        }

        private static bool Day8CheckCondition(int value1, string comparer, int value2)
        {
            return comparer.Equals("==") ? value1 == value2
                : comparer.Equals("<") ? value1 < value2
                : comparer.Equals("<=") ? value1 <= value2
                : comparer.Equals(">=") ? value1 >= value2
                : comparer.Equals(">") ? value1 > value2
                : value1 != value2;
        }

        private static int Day9Part1(string input)
        {
            return Program.Day9CreateGroupsStream(input)
                .Where(t => t.Item2)
                .Sum(t => t.Item5);
        }

        private static int Day9Part2(string input)
        {
            return Program.Day9CreateGroupsStream(input)
                .Count(t => t.Item1 == 0 && t.Item4 && !t.Item3);
        }

        private static IEnumerable<Tuple<int, bool, bool, bool, int>> Day9CreateGroupsStream(string input)
        {
            return input
                .TupleScan(0, false, false, false, 0,
                    (cancelled, groupStart, garbageStart, inGarbage, depth, ch) =>
                        cancelled == 2 ? Tuple.Create(1, false, false, inGarbage, depth)
                            : ch == '!' ? Tuple.Create(2, false, false, inGarbage, depth)
                            : inGarbage
                                ? (ch == '>' ? Tuple.Create(0, false, false, false, depth)
                                : Tuple.Create(0, false, false, true, depth))
                            : ch == '<' ? Tuple.Create(0, false, true, true, depth)
                            : ch == '{' ? Tuple.Create(0, true, false, false, depth + 1)
                            : ch == '}' ? Tuple.Create(0, false, false, false, depth - 1)
                            : Tuple.Create(0, false, false, false, depth));
        }

        private static int Day10Part1(string input)
        {
            var startingState = Enumerable
                .Range(0, 256)
                .ToImmutableArray();

            var finalState = input
                .Split(",")
                .Select(int.Parse)
                .Select((length, skipCount) => Tuple.Create(length, skipCount))
                .TupleAggregate(startingState, 0,
                    (state, currentPosition, length, skipSize) => Tuple.Create(
                        Program.Day10Twist(state, currentPosition, length),
                        (currentPosition + length + skipSize) % state.Length));

            return finalState.Item1
                .Take(2)
                .Aggregate(1, (a, v) => a * v);
        }

        private static ImmutableArray<int> Day10Twist(ImmutableArray<int> lastArray, int currentPosition, int length)
        {
            var arr = lastArray.ToArray();
            for (var count = 0; count < length / 2; count++)
            {
                var pos = (currentPosition + count) % lastArray.Length;
                var other = (currentPosition + length - count - 1) % lastArray.Length;

                var temp = arr[pos];
                arr[pos] = arr[other];
                arr[other] = temp;
            }

            return arr.ToImmutableArray();
        }

        private static string Day10Part2(string input)
        {
            return string.Join("", Program.Day10KnotHash(input)
                .Select(b => string.Format("{0:x2}", b)));
        }

        private static ImmutableArray<int> Day10ToLengths(string input)
        {
            return System.Text.Encoding.UTF8.GetBytes(input)
                .Select(b => (int)b)
                .Concat(
                    new[]
                    {
                        17, 31, 73, 47, 23
                    })
                .ToImmutableArray();
        }

        private static IEnumerable<byte> Day10KnotHash(string input)
        {
            var startingState = Enumerable
                .Range(0, 256)
                .ToImmutableArray();

            var finalState = Program.Day10ToLengths(input)
                .Repeat(64)
                .Select((length, skipCount) => Tuple.Create(length, skipCount))
                .TupleAggregate(startingState, 0,
                    (state, currentPosition, length, skipSize) => Tuple.Create(
                        Program.Day10Twist(state, currentPosition, length),
                        (currentPosition + length + skipSize) % state.Length));

            return finalState.Item1
                .Batch(16)
                .Select(b => (byte) b.Aggregate(0, (x, y) => x ^ y));
        }

        private static double Day11Part1(string input)
        {
            var finalPosition = input
                .Split(",")
                .Select(s => s.Trim())
                .Select(Program.Day11DirectionToLocationChange)
                .TupleAggregate(0d, 0d,
                    (cx, cy, dx, dy) => Tuple.Create(cx + dx, cy + dy));

            return Program.Day11HexDistance(finalPosition.Item1, finalPosition.Item2);
        }

        private static Tuple<double, double> Day11DirectionToLocationChange(string s)
        {
            switch (s)
            {
                case "s":
                    return Tuple.Create<double, double>(0, -1);
                case "se":
                    return Tuple.Create<double, double>(1, -0.5);
                case "sw":
                    return Tuple.Create<double, double>(-1, -0.5);
                case "n":
                    return Tuple.Create<double, double>(0, 1);
                case "ne":
                    return Tuple.Create<double, double>(1, 0.5);
                case "nw":
                    return Tuple.Create<double, double>(-1, 0.5);
                default:
                    Console.WriteLine($"Bad direction: {s}");
                    return Tuple.Create<double, double>(0, 0);
            }
        }

        private static double Day11HexDistance(double x, double y)
        {
            return Math.Abs(x) + Math.Max(Math.Abs(y) - Math.Abs(x) / 2, 0);
        }

        private static double Day11Part2(string input)
        {
            return input
                .Split(",")
                .Select(s => s.Trim())
                .Select(Program.Day11DirectionToLocationChange)
                .TupleScan(0d, 0d,
                    (cx, cy, dx, dy) => Tuple.Create(cx + dx, cy + dy))
                .TupleSelect(Program.Day11HexDistance)
                .Max();
        }

        private static int Day12Part1(string input)
        {
            var inputs = input
                .SelectLines()
                .Select(line => line.Split(" "))
                .Select(
                    parts => Tuple.Create(
                        int.Parse(parts[0]),
                        parts
                            .Skip(2)
                            .Select(s => s.TrimEnd(','))
                            .Select(int.Parse)
                            .ToImmutableHashSet()))
                .ToImmutableDictionary(t => t.Item1, t => t.Item2);

            var connected = Program.Day12GetConnected(0, inputs);

            return connected.Count;
        }

        private static ImmutableHashSet<int> Day12GetConnected(int startNode, ImmutableDictionary<int, ImmutableHashSet<int>> inputs)
        {
            return EnumerableExtensions.TupleGenerate(
                new [] {startNode}.ToImmutableHashSet(),
                ImmutableList.Create(startNode),
                (_, queue) => queue.Count > 0,
                (connected, queue) => Tuple.Create(
                    connected.Union(inputs[queue[0]]),
                    queue.RemoveAt(0).AddRange(inputs[queue[0]].Except(connected))))
                .Last()
                .Item1;
        }

        private static int Day12Part2(string input)
        {
            var inputs = input
                .SelectLines()
                .Select(line => line.Split(" "))
                .Select(
                    parts => Tuple.Create(
                        int.Parse(parts[0]),
                        parts
                            .Skip(2)
                            .Select(s => s.TrimEnd(','))
                            .Select(int.Parse)
                            .ToImmutableHashSet()))
                .ToImmutableDictionary(t => t.Item1, t => t.Item2);

            var unconnectedNodes = inputs
                .Select(p => p.Key)
                .ToImmutableHashSet();

            return EnumerableExtensions.Generate(
                    unconnectedNodes,
                    remainingNodes => remainingNodes.Count > 0,
                    remainingNodes => remainingNodes.Except(Program.Day12GetConnected(remainingNodes.First(), inputs)))
                .Count();
        }

        private static int Day13Part1(string input)
        {
            var inputs = input
                .SelectLines()
                .Select(line => line.Split(" "))
                .Select(
                    parts => Tuple.Create(
                        int.Parse(parts[0].TrimEnd(':')),
                        int.Parse(parts[1])))
                .ToImmutableDictionary(t => t.Item1, t => t.Item2);

            return EnumerableExtensions.Generate(
                Tuple.Create(0, 0, inputs.ToImmutableDictionary(p => p.Key, _ => Tuple.Create(0, true))),
                t => t.Item1 <= inputs.Select(p => p.Key).Max(),
                t => Tuple.Create(
                    t.Item1 + 1,
                    t.Item2 + (t.Item3.GetValueOrDefault(t.Item1, Tuple.Create(-1, false)).Item1 == 0
                        ? t.Item1 * inputs[t.Item1]
                        : 0),
                    Program.Day13NextStep(t.Item3, inputs)))
                .Last()
                .Item2;
        }

        private static ImmutableDictionary<int, Tuple<int, bool>> Day13NextStep(ImmutableDictionary<int, Tuple<int, bool>> oldPositions, ImmutableDictionary<int, int> inputs)
        {
            return oldPositions
                .ToImmutableDictionary(p => p.Key, p => p.Value.Item2
                    ? p.Value.Item1 >= inputs[p.Key] - 1 ? Tuple.Create(inputs[p.Key] - 2, false) : Tuple.Create(p.Value.Item1 + 1, true)
                    : p.Value.Item1 <= 0 ? Tuple.Create(1, true) : Tuple.Create(p.Value.Item1 - 1, false));
        }

        private static int Day13Part2(string input)
        {
            var inputs = input
                .SelectLines()
                .Select(line => line.Split(" "))
                .Select(
                    parts => Tuple.Create(
                        int.Parse(parts[0].TrimEnd(':')),
                        int.Parse(parts[1])))
                .ToImmutableDictionary(t => t.Item1, t => t.Item2);

            return Enumerable
                .Range(0, 10000000)
                .First(startTime => Program.Day13Caught(startTime, inputs));
        }

        private static bool Day13Caught(int startTime, ImmutableDictionary<int, int> inputs)
        {
            return inputs
                .All(p => (p.Key + startTime) % ((p.Value - 1) * 2) != 0);
        }

        private static string Day14KnotHash(string input)
        {
            return string.Join("", Program.Day10KnotHash(input)
                .Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
        }

        private static int Day14Part1(string input)
        {
            return Program.Day14Parse(input)
                .Sum(hash => hash.Count(c => c == '1'));
        }

        private static IEnumerable<string> Day14Parse(string input)
        {
            return Enumerable
                .Range(0, 128)
                .Select(i => $"{input}-{i}")
                .Select(Program.Day14KnotHash);
        }

        private static int Day14Part2(string input)
        {
            var usedArray = Program.Day14Parse(input)
                .SelectMany(hash => hash.Select(c => c == '1'))
                .ToImmutableArray();

            var connections = Enumerable.Range(0, 128 * 128)
                .Where(i => usedArray[i])
                .ToImmutableDictionary(i => i, i => Program.Day14GetNeighbours(i, usedArray).ToImmutableHashSet());

            var unconnectedNodes = connections
                .Select(p => p.Key)
                .ToImmutableHashSet();

            return EnumerableExtensions.Generate(
                    Tuple.Create(unconnectedNodes, ImmutableHashSet<int>.Empty),
                    t => t.Item1.Count > 0,
                    t =>
                    {
                        var thing = Program.Day12GetConnected(t.Item1.First(), connections);
                        return Tuple.Create(t.Item1.Except(thing), thing);
                    })
                .Count();
        }

        private static IEnumerable<int> Day14GetNeighbours(int i, ImmutableArray<bool> usedArray)
        {
            var x = i % 128;
            var y = i / 128;

            if (x - 1 >= 0 && usedArray[i - 1])
            {
                yield return i - 1;
            }
            if (x + 1 < 128 && usedArray[i + 1])
            {
                yield return i + 1;
            }
            if (y - 1 >= 0 && usedArray[i - 128])
            {
                yield return i - 128;
            }
            if (y + 1 < 128 && usedArray[i + 128])
            {
                yield return i + 128;
            }
        }

        private static int Day15Part1(int aStart, int bStart)
        {
            return Program.Day15Generator(aStart, 16807)
                .Zip(Program.Day15Generator(bStart, 48271), Tuple.Create)
                .Take(40000000)
                .Count(t => (t.Item1 & 0xFFFF) == (t.Item2 & 0xFFFF));
        }

        private static int Day15Part2(int aStart, int bStart)
        {
            return Program.Day15Generator(aStart, 16807).Where(Program.Day15Multiple(4))
                .Zip(Program.Day15Generator(bStart, 48271).Where(Program.Day15Multiple(8)), Tuple.Create)
                .Take(5000000)
                .Count(t => (t.Item1 & 0xFFFF) == (t.Item2 & 0xFFFF));
        }

        private static IEnumerable<long> Day15Generator(long seed, long factor)
        {
            return EnumerableExtensions
                .Generate(
                    seed,
                    _ => true,
                    last => last * factor % 2147483647)
                .Skip(1);
        }

        private static Func<long, bool> Day15Multiple(int requiredMultiple)
        {
            return l => l % requiredMultiple == 0;
        }

        private static string Day16Part1(string input)
        {
            var inputs = input
                .Split(",")
                .Select(p =>
                {
                    var a = p[0];
                    var parts = p.Substring(1).Split('/');
                    return Tuple.Create(a, parts[0], parts.Length > 1 ? parts[1] : string.Empty);
                });

            return Program.Day16OneDance(inputs, "abcdefghijklmnop");
        }

        private static string Day16OneDance(IEnumerable<Tuple<char, string, string>> inputs, string start)
        {
            return inputs
                .Aggregate(
                    start,
                    (last, move) =>
                    {
                        switch (move.Item1)
                        {
                            case 's':
                                var amount = int.Parse(move.Item2);
                                return new string(last
                                    .Skip(16 - amount)
                                    .Concat(last.Take(16 - amount))
                                    .ToArray());
                            case 'x':
                                var index1 = int.Parse(move.Item2);
                                var index2 = int.Parse(move.Item3);
                                return new string(last
                                    .Select((c, i) => i == index1 ? last[index2]
                                        : i == index2 ? last[index1]
                                        : c)
                                    .ToArray());
                            default:
                                var ch1 = move.Item2[0];
                                var ch2 = move.Item3[0];
                                return new string(last
                                    .Select(c => c == ch1 ? ch2
                                        : c == ch2 ? ch1
                                        : c)
                                    .ToArray());
                        }
                    });
        }

        private static string Day16Part2(string input)
        {
            var inputs = input
                .Split(",")
                .Select(p =>
                {
                    var a = p[0];
                    var parts = p.Substring(1).Split('/');
                    return Tuple.Create(a, parts[0], parts.Length > 1 ? parts[1] : string.Empty);
                })
                .ToArray();

            var period = EnumerableExtensions.Generate(
                    "abcdefghijklmnop",
                    _ => true,
                    last => Program.Day16OneDance(inputs, last))
                .Select((s, i) => Tuple.Create(s, i))
                .Skip(1)
                .TakeWhile(s => !string.Equals(s.Item1, "abcdefghijklmnop"))
                .Count() + 1;

            var extraDances = 1000000000L % 36;

            return Program.Day16OneDance(inputs.Repeat((int) extraDances), "abcdefghijklmnop");
        }

        private static int Day17Part1(int input)
        {
            var finalState = Program.Day17Spinlock1(steps: input, lastValue: 2017)
                .Last();

            return finalState.Item2[finalState.Item1 + 1];
        }

        private static IEnumerable<Tuple<int, ImmutableList<int>>> Day17Spinlock1(int steps, int lastValue)
        {
            return EnumerableExtensions.TupleGenerate(
                    0,
                    ImmutableList.Create<int>(0),
                    (_, buffer) => buffer.Count <= lastValue + 1,
                    (currentPosition, buffer) => Tuple.Create(
                        (currentPosition + steps) % buffer.Count + 1,
                        buffer.Insert((currentPosition + steps) % buffer.Count + 1, buffer.Count)));
        }

        private static int Day17Part2(int input)
        {
            return Program.Day17Spinlock1BeforeZero(steps: input, repetitions: 50000000)
                .Last()
                .Item2;
        }

        private static IEnumerable<Tuple<int, int>> Day17Spinlock1BeforeZero(int steps, int repetitions)
        {
            return Enumerable.Range(1, repetitions)
                .TupleScan(
                    0,
                    -1,
                    (currentPosition, valueAfterZero, next) => Tuple.Create(
                        (currentPosition + steps) % next + 1,
                        (currentPosition + steps) % next == 0 ? next : valueAfterZero));
        }

        private static long Day18Part1(string input)
        {
            var instructions = Program.Day18ReadInstructions(input);

            return Program.Day18GetRecoveredNote(instructions, -1, 0, ImmutableDictionary<char, long>.Empty);
        }

        private static ImmutableArray<(string Instruction, string X, string Y)> Day18ReadInstructions(string input)
        {
            return input
                .SelectLines()
                .Select(line => line.Split(" "))
                .Select(
                    parts => (
                        Instruction: parts[0],
                        X: parts[1],
                        Y: parts.Length > 2 ? parts[2] : string.Empty))
                .ToImmutableArray();
        }

        private static long Day18GetRecoveredNote(
            ImmutableArray<(string Instruction, string X, string Y)> instructions,
            long lastNote,
            int instructionPointer,
            ImmutableDictionary<char, long> registers)
        {
            var instruction = instructions[instructionPointer];

            switch (instruction.Item1)
            {
                case "snd":
                {
                    var valueOfX = Program.Day18ValueOfX(registers, instruction);
                    return Program.Day18GetRecoveredNote(instructions, valueOfX, instructionPointer + 1, registers);
                }
                case "set":
                {
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    return Program.Day18GetRecoveredNote(instructions, lastNote, instructionPointer + 1, registers.UpdateValue(instruction.Item2[0], 0, _ => valueOfY));
                }
                case "add":
                {
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    return Program.Day18GetRecoveredNote(instructions, lastNote, instructionPointer + 1, registers.UpdateValue(instruction.Item2[0], 0, x => x + valueOfY));
                }
                case "mul":
                {
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    return Program.Day18GetRecoveredNote(instructions, lastNote, instructionPointer + 1, registers.UpdateValue(instruction.Item2[0], 0, x => x * valueOfY));
                }
                case "mod":
                {
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    return Program.Day18GetRecoveredNote(instructions, lastNote, instructionPointer + 1, registers.UpdateValue(instruction.Item2[0], 0, x => x % valueOfY));
                }
                case "rcv":
                {
                    var valueOfX = Program.Day18ValueOfX(registers, instruction);
                    return valueOfX != 0
                        ? lastNote
                        : Program.Day18GetRecoveredNote(instructions, lastNote, instructionPointer + 1, registers);
                }
                case "jgz":
                {
                    var valueOfX = Program.Day18ValueOfX(registers, instruction);
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    return valueOfX > 0
                        ? Program.Day18GetRecoveredNote(instructions, lastNote, (int) (instructionPointer + valueOfY), registers)
                        : Program.Day18GetRecoveredNote(instructions, lastNote, instructionPointer + 1, registers);
                }
                default:
                    throw new InvalidOperationException($"Got invalid instruction: {instruction}");
            }
        }

        private static long Day18ValueOfX(ImmutableDictionary<char, long> registers, (string Instruction, string X, string Y) instruction)
        {
            var valueOfX = long.TryParse(instruction.X, out var parsedX) ? parsedX : registers.GetValueOrDefault(instruction.X[0], 0);
            return valueOfX;
        }

        private static long Day18ValueOfY(ImmutableDictionary<char, long> registers, (string Instruction, string X, string Y) instruction)
        {
            var valueOfY = long.TryParse(instruction.Y, out var parsedY) ? parsedY : registers.GetValueOrDefault(instruction.Y[0], 0);
            return valueOfY;
        }

        private static long Day18Part2(string input)
        {
            var instructions = Program.Day18ReadInstructions(input);

            return EnumerableExtensions.TupleGenerate(
                Tuple.Create(ImmutableList<long>.Empty, 0, ImmutableDictionary<char, long>.Empty.Add('p', 0)),
                Tuple.Create(ImmutableList<long>.Empty, 0, ImmutableDictionary<char, long>.Empty.Add('p', 1)),
                0,
                (program0, program1, turn) => program0.Item1.Count + program1.Item1.Count > 0 || program0.Item2 == 0,
                (program0, program1, turn) => turn == 0
                    ? Tuple.Create(Program.Day18RunOnce(instructions, program1.Item1, ImmutableList<long>.Empty, program0.Item2, program0.Item3), program1, 1)
                    : Tuple.Create(program0, Program.Day18RunOnce(instructions, program0.Item1, ImmutableList<long>.Empty, program1.Item2, program1.Item3), 0))
                .Sum(state => state.Item2.Item1.Count) / 2;
        }

        private static Tuple<ImmutableList<long>, int, ImmutableDictionary<char, long>> Day18RunOnce(
            ImmutableArray<(string Instruction, string X, string Y)> instructions,
            ImmutableList<long> receiveQueue,
            ImmutableList<long> sendQueue,
            int instructionPointer,
            ImmutableDictionary<char, long> registers)
        {
            var instruction = instructions[instructionPointer];

            switch (instruction.Item1)
            {
                case "snd":
                {
                    var valueOfX = Program.Day18ValueOfX(registers, instruction);
                    return Program.Day18RunOnce(instructions, receiveQueue, sendQueue.Add(valueOfX), instructionPointer + 1, registers);
                }
                case "set":
                {
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    return Program.Day18RunOnce(instructions, receiveQueue, sendQueue, instructionPointer + 1, registers.UpdateValue(instruction.Item2[0], 0, _ => valueOfY));
                }
                case "add":
                {
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    return Program.Day18RunOnce(instructions, receiveQueue, sendQueue, instructionPointer + 1, registers.UpdateValue(instruction.Item2[0], 0, x => x + valueOfY));
                }
                case "mul":
                {
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    return Program.Day18RunOnce(instructions, receiveQueue, sendQueue, instructionPointer + 1, registers.UpdateValue(instruction.Item2[0], 0, x => x * valueOfY));
                }
                case "mod":
                {
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    return Program.Day18RunOnce(instructions, receiveQueue, sendQueue, instructionPointer + 1, registers.UpdateValue(instruction.Item2[0], 0, x => x % valueOfY));
                }
                case "rcv":
                {
                    return receiveQueue.Count != 0
                        ? Program.Day18RunOnce(instructions, receiveQueue.RemoveAt(0), sendQueue, instructionPointer + 1, registers.UpdateValue(instruction.Item2[0], 0, _ => receiveQueue[0]))
                        : Tuple.Create(sendQueue, instructionPointer, registers);
                }
                case "jgz":
                {
                    var valueOfX = Program.Day18ValueOfX(registers, instruction);
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    return valueOfX > 0
                        ? Program.Day18RunOnce(instructions, receiveQueue, sendQueue, (int) (instructionPointer + valueOfY), registers)
                        : Program.Day18RunOnce(instructions, receiveQueue, sendQueue, instructionPointer + 1, registers);
                }
                default:
                    throw new InvalidOperationException($"Got invalid instruction: {instruction}");
            }
        }

        private static string Day19Part1(string input)
        {
            var map = input
                .SelectLines()
                .Select(s => s.ToImmutableArray())
                .ToImmutableArray();

            var startingCol = map[0]
                .TakeWhile(ch => ch == ' ')
                .Count();

            var knownChars = new[]
            {
                '-',
                '|',
                '+',
                'x'
            }.ToImmutableHashSet();

            return new string(EnumerableExtensions
                .TupleGenerate(
                    0,
                    startingCol,
                    'd',
                    (_row, _col, direction) => direction != 's',
                    (row, col, direction) => Program.Day19GetNextStep(row, col, direction, map))
                .Select(t => map[t.Item1][t.Item2])
                .Where(ch => !knownChars.Contains(ch))
                .ToArray());
        }

        private static Tuple<int, int, char> Day19GetNextStep(int row, int col, char direction, ImmutableArray<ImmutableArray<char>> map)
        {
            var atPlus = map[row][col] == '+';
            var upBlank = row == 0 || map[row - 1][col] == ' ';
            var leftBlank = col == 0 || map[row][col - 1] == ' ';
            var vertical = direction == 'u' || direction == 'd';

            var nextDirection = !atPlus ? direction
                : vertical ? (leftBlank ? 'r' : 'l')
                : upBlank ? 'd' : 'u';

            var nextRow = nextDirection == 'd' ? row + 1
                : nextDirection == 'u' ? row - 1
                : row;

            var nextCol = nextDirection == 'r' ? col + 1
                : nextDirection == 'l' ? col - 1
                : col;

            return Tuple.Create(nextRow, nextCol, map[nextRow][nextCol] == ' ' ? 's' : nextDirection);
        }

        private static int Day19Part2(string input)
        {
            var map = input
                .SelectLines()
                .Select(s => s.ToImmutableArray())
                .ToImmutableArray();

            var startingCol = map[0]
                .TakeWhile(ch => ch == ' ')
                .Count();

            var knownChars = new[]
            {
                '-',
                '|',
                '+',
                'x'
            }.ToImmutableHashSet();

            return EnumerableExtensions
                .TupleGenerate(
                    0,
                    startingCol,
                    'd',
                    (_row, _col, direction) => direction != 's',
                    (row, col, direction) => Program.Day19GetNextStep(row, col, direction, map))
                .Count();
        }

        private static int Day20Part1(string input)
        {
            var vectors = input
                .SelectLines()
                .Select(l => Regex
                    .Replace(l, " ?[pav]=<|>", "")
                    .Split(',')
                    .Select(int.Parse)
                    .ToImmutableArray());

            return Program.Day20GetSlowest(vectors);
        }

        private static int Day20GetSlowest(IEnumerable<ImmutableArray<int>> vectors)
        {
            var manhattanAccelerations = vectors
                .Select<ImmutableArray<int>, int>(v => v.TakeLast(3).Select(Math.Abs).Sum());

            return manhattanAccelerations
                .Select((accel, index) => Tuple.Create(index, accel))
                .OrderBy(t => t.Item2)
                .First()
                .Item1;
        }

        private static int Day20Part2(string input)
        {
            var vectors = input
                .SelectLines()
                .Select(l => Regex
                    .Replace(l, " ?[pav]=<|>", "")
                    .Split(',')
                    .Select(int.Parse)
                    .ToImmutableArray())
                .ToImmutableArray();

            var slowest = Program.Day20GetSlowest(vectors);

            var states = EnumerableExtensions.Generate(
                vectors,
                v => Program.Day20GetClosest(v) != Program.Day20DistanceFromOrigin(v[slowest]),
                v => v.Select(Program.Day20DoStep).ToImmutableArray());

            return states
                .Scan(
                    ImmutableHashSet<int>.Empty,
                    (removed, state) => removed.Union(
                        state
                            .Select((vector, index) => Tuple.Create(index, Tuple.Create(vector[0], vector[1], vector[2])))
                            .Where(t => !removed.Contains(t.Item1))
                            .GroupBy(t => t.Item2)
                            .Where(g => g.Count() > 1)
                            .SelectMany(g => g.Select(t => t.Item1))))
                .Select(removed => vectors.Length - removed.Count)
                .Last();
        }

        private static long Day20GetClosest(ImmutableArray<ImmutableArray<int>> vectors)
        {
            return vectors
                .Select(Program.Day20DistanceFromOrigin)
                .Min();
        }

        private static long Day20DistanceFromOrigin(ImmutableArray<int> v)
        {
            return v.Take(3).Select(Math.Abs).Sum();
        }

        private static ImmutableArray<int> Day20DoStep(ImmutableArray<int> lastState)
        {
            return new[]
            {
                lastState[0] + lastState[3] + lastState[6],
                lastState[1] + lastState[4] + lastState[7],
                lastState[2] + lastState[5] + lastState[8],
                lastState[3] + lastState[6],
                lastState[4] + lastState[7],
                lastState[5] + lastState[8],
                lastState[6],
                lastState[7],
                lastState[8]
            }.ToImmutableArray();
        }

        private static int Day21Part1(string input)
        {
            return Program.Day21DrawArt(input, 5);
        }

        private static int Day21Part2(string input)
        {
            return Program.Day21DrawArt(input, 18);
        }

        private static int Day21DrawArt(string input, int iterations)
        {
            var twoEnhancements = input
                .SelectLines()
                .Take(6)
                .SelectMany(s => Program.Day21GetEnhancement(s, 2))
                .ToImmutableDictionary(t => t.Input, t => t.Enhancement);

            var threeEnhancements = input
                .SelectLines()
                .Skip(6)
                .SelectMany(s => Program.Day21GetEnhancement(s, 3))
                .ToImmutableDictionary(t => t.Input, t => t.Enhancement);

            var start = new[] { false, true, false, false, false, true, true, true, true };

            var art = EnumerableExtensions
                .Generate(
                    start,
                    _ => true,
                    pattern => Program.Day21GetNextPattern(pattern, twoEnhancements, threeEnhancements))
                .Skip(1)
                .Take(iterations)
                .Last();

            return Program.Day21CountBits(art);
        }

        private static int Day21CountBits(bool[] art)
        {
            return art
                .Count(bit => bit);
        }

        private static bool[] Day21GetNextPattern(bool[] pattern, IReadOnlyDictionary<int, int> twoEnhancements, IReadOnlyDictionary<int, int> threeEnhancements)
        {
            var size = (int) Math.Sqrt(pattern.Length);
            if (size % 2 == 0)
            {
                var newSize = size / 2 * 3;

                return pattern
                    .Day21BreakApartPattern(size, 2)
                    .Select(tinyPattern => twoEnhancements[tinyPattern])
                    .Day21CombinePatterns(newSize, 3);
            }
            else
            {
                var newSize = size / 3 * 4;

                return pattern
                    .Day21BreakApartPattern(size, 3)
                    .Select(tinyPattern => threeEnhancements[tinyPattern])
                    .Day21CombinePatterns(newSize, 4);
            }
        }

        private static IEnumerable<int> Day21BreakApartPattern(this bool[] pattern, int patternSize, int brokenSize)
        {
            var numberOfThings = patternSize / brokenSize;

            return Enumerable
                .Range(0, numberOfThings)
                .SelectMany(row => Enumerable.Range(0, numberOfThings).Select(col => (Row: row, Column: col)))
                .Select(subPatternLocation => pattern.Day21ExtractOne(patternSize, brokenSize, subPatternLocation.Row * brokenSize, subPatternLocation.Column * brokenSize));
        }

        private static int Day21ExtractOne(this bool[] pattern, int patternSize, int brokenSize, int patternRowStart, int patternColumnStart)
        {
            return Enumerable
                .Range(0, brokenSize)
                .SelectMany(r => Enumerable.Range(0, brokenSize).Select(c => (Row: r, Column: c)))
                .Sum(subPatternPixel =>
                {
                    var patternBitLocation = (subPatternPixel.Row + patternRowStart) * patternSize
                        + (subPatternPixel.Column + patternColumnStart);
                    var subPatternBitLocation = brokenSize * brokenSize - 1
                        - subPatternPixel.Row * brokenSize
                        - subPatternPixel.Column;
                    return (pattern[patternBitLocation] ? 1 : 0) << subPatternBitLocation;
                });
        }

        private static bool[] Day21CombinePatterns(this IEnumerable<int> subPatterns, int newPatternSize, int brokenSize)
        {
            var numberOfThings = newPatternSize / brokenSize;
            var subPatternsArray = subPatterns.ToImmutableArray();

            var newPattern = new bool[newPatternSize * newPatternSize];
            foreach (var row in Enumerable.Range(0, numberOfThings))
            {
                var subPatternRowStart = row * brokenSize;
                foreach (var col in Enumerable.Range(0, numberOfThings))
                {
                    var subPatternColumnStart = col * brokenSize;
                    var subPattern = subPatternsArray[row * numberOfThings + col];
                    foreach (var subPatternRowPixel in Enumerable.Range(0, brokenSize))
                    {
                        foreach (var subPatternColumnPixel in Enumerable.Range(0, brokenSize))
                        {
                            var subPatternBitLocation = brokenSize * brokenSize - 1
                                - (subPatternRowPixel * brokenSize)
                                - subPatternColumnPixel;
                            var patternBitLocation = (subPatternRowPixel + subPatternRowStart) * newPatternSize
                                + (subPatternColumnPixel + subPatternColumnStart);
                            newPattern[patternBitLocation] = ((subPattern >> subPatternBitLocation) & 0b1) == 0b1;
                        }
                    }
                }
            }

            return newPattern;
        }

        private static IEnumerable<(int Input, int Enhancement)> Day21GetEnhancement(string enhancement, int size)
        {
            var parts = enhancement.Split(" => ");

            return Program.Day21GetRotations(Program.Day21ToInt(parts[0]), size)
                .Distinct()
                .Select(l => (l, Program.Day21ToInt(parts[1])));
        }

        private static IEnumerable<int> Day21GetRotations(int start, int size)
        {
            if (size == 2)
            {
                var bits = new[]
                {
                    (start & 0b1000) >> 3,
                    (start & 0b0100) >> 2,
                    (start & 0b0010) >> 1,
                    (start & 0b0001)
                };

                // no rotations or flips
                yield return start; //yield return Program.Day21BitsToNum(bits, 0, 1, 2, 3);
                // right 90 degrees
                yield return Program.Day21BitsToNum(bits, 2, 0, 3, 1);
                // right 90 degrees + flip vertically
                yield return Program.Day21BitsToNum(bits, 3, 1, 2, 0);
                // right 90 degrees + flip horizontally
                yield return Program.Day21BitsToNum(bits, 0, 2, 1, 3);
                // right 180 degrees
                yield return Program.Day21BitsToNum(bits, 3, 2, 1, 0);
                // right 180 degrees + flip vertically (skip R0+H)
                // right 180 degrees + flip horizontally (skip R0+V)
                // right 270 degrees
                yield return Program.Day21BitsToNum(bits, 1, 3, 0, 2);
                // right 270 degrees + flip vertically (skip R90+H)
                // right 270 degrees + flip horizontally (skip R90+V)
                // flip vertically
                yield return Program.Day21BitsToNum(bits, 2, 3, 0, 1);
                // flip horizontally
                yield return Program.Day21BitsToNum(bits, 1, 0, 3, 2);
            }
            else if (size == 3)
            {
                var bits = new[]
                {
                    (start & 0b100000000) >> 8,
                    (start & 0b010000000) >> 7,
                    (start & 0b001000000) >> 6,
                    (start & 0b000100000) >> 5,
                    (start & 0b000010000) >> 4,
                    (start & 0b000001000) >> 3,
                    (start & 0b000000100) >> 2,
                    (start & 0b000000010) >> 1,
                    (start & 0b000000001)
                };

                // no rotations or flips
                yield return start; //yield return Program.Day21BitsToNum(bits, 0, 1, 2, 3, 4, 5, 6, 7, 8);
                // right 90 degrees
                yield return Program.Day21BitsToNum(bits, 6, 3, 0, 7, 4, 1, 8, 5, 2);
                // right 90 degrees + flip vertically
                yield return Program.Day21BitsToNum(bits, 8, 5, 2, 7, 4, 1, 6, 3, 0);
                // right 90 degrees + flip horizontally
                yield return Program.Day21BitsToNum(bits, 0, 3, 6, 1, 4, 7, 2, 5, 8);
                // right 180 degrees
                yield return Program.Day21BitsToNum(bits, 8, 7, 6, 5, 4, 3, 2, 1, 0);
                // right 180 degrees + flip vertically (skip R0+H)
                // right 180 degrees + flip horizontally (skip R0+V)
                // right 270 degrees
                yield return Program.Day21BitsToNum(bits, 2, 5, 8, 1, 4, 7, 0, 3, 6);
                // right 270 degrees + flip vertically (skip R90+H)
                // right 270 degrees + flip horizontally (skip R90+V)
                // flip vertically
                yield return Program.Day21BitsToNum(bits, 6, 7, 8, 3, 4, 5, 0, 1, 2);
                // flip horizontally
                yield return Program.Day21BitsToNum(bits, 2, 1, 0, 5, 4, 3, 8, 7, 6);
            }
        }

        private static int Day21BitsToNum(int[] bits, params int[] selectedBits)
        {
            return selectedBits
                .Aggregate(0, (acc, selectedBit) => (acc << 1) | bits[selectedBit]);
        }

        private static int Day21ToInt(string part)
        {
            return part
                .Where(ch => ch == '.' || ch == '#')
                .Select(ch => ch == '#' ? 1 : 0)
                .Reverse()
                .Aggregate(0, (acc, bit) => acc * 2 + bit);
        }

        private static int Day22Part1(string input)
        {
            var map = input
                .SelectLines()
                .Select(s => s.ToImmutableArray())
                .ToImmutableArray();

            var yMiddle = (map.Length - 1) / 2;
            var xMiddle = (map[0].Length - 1) / 2;

            var startingInfections = map
                .SelectMany((mapRow, row) =>
                {
                    return mapRow.Select((location, col) => (Infected: location == '#', Row: row - yMiddle, Column: col - xMiddle));
                })
                .Where(t => t.Infected)
                .Select(t => (t.Row, t.Column))
                .ToImmutableHashSet();

            return EnumerableExtensions
                .TupleGenerate(
                    startingInfections,
                    (Row: 0, Column: 0),
                    'u',
                    false,
                    Program.Day22DoOneBurst)
                .Take(1 + 10000)
                .Count(t => t.Item4);
        }

        private static (ImmutableHashSet<(int, int)>, (int Row, int Column), char, bool) Day22DoOneBurst(ImmutableHashSet<(int, int)> infectedLocations, (int Row, int Column) location, char direction, bool causedInfection)
        {
            var locationInfected = infectedLocations.Contains(location);
            var nextDirection = locationInfected
                ? (direction == 'u' ? 'r' : direction == 'r' ? 'd' : direction == 'd' ? 'l' : 'u')
                : (direction == 'u' ? 'l' : direction == 'l' ? 'd' : direction == 'd' ? 'r' : 'u');
            var nextInfectionLocations = locationInfected
                ? infectedLocations.Remove(location)
                : infectedLocations.Add(location);
            var nextRow = nextDirection == 'd' ? location.Row + 1
                : nextDirection == 'u' ? location.Row - 1
                : location.Row;
            var nextCol = nextDirection == 'r' ? location.Column + 1
                : nextDirection == 'l' ? location.Column - 1
                : location.Column;

            return (nextInfectionLocations, (nextRow, nextCol), nextDirection, !locationInfected);
        }

        private static int Day22Part2(string input)
        {
            var map = input
                .SelectLines()
                .Select(s => s.ToImmutableArray())
                .ToImmutableArray();

            var yMiddle = (map.Length - 1) / 2;
            var xMiddle = (map[0].Length - 1) / 2;

            var startingInfections = map
                .SelectMany((mapRow, row) =>
                {
                    return mapRow.Select((location, col) => (Infected: location == '#', Row: row - yMiddle, Column: col - xMiddle));
                })
                .Where(t => t.Infected)
                .Select(t => (t.Row, t.Column))
                .ToImmutableHashSet();

            return EnumerableExtensions
                .TupleGenerate(
                    startingInfections,
                    ImmutableHashSet<(int, int)>.Empty,
                    ImmutableHashSet<(int, int)>.Empty,
                    (Row: 0, Column: 0),
                    'u',
                    false,
                    Program.Day22DoOneBurst2)
                .Take(1 + 10000000)
                .Count(t => t.Item6);
        }

        private static (ImmutableHashSet<(int, int)>, ImmutableHashSet<(int, int)>, ImmutableHashSet<(int, int)>, (int Row, int Column), char, bool) Day22DoOneBurst2(
            ImmutableHashSet<(int, int)> infectedLocations,
            ImmutableHashSet<(int, int)> weakLocations,
            ImmutableHashSet<(int, int)> flaggedLocations,
            (int Row, int Column) location,
            char direction,
            bool causedInfection)
        {
            var locationInfected = infectedLocations.Contains(location);
            var locationWeak = weakLocations.Contains(location);
            var locationFlagged = flaggedLocations.Contains(location);
            var locationClean = !(locationInfected || locationFlagged || locationWeak);
            var nextDirection = locationInfected ? (direction == 'u' ? 'r' : direction == 'r' ? 'd' : direction == 'd' ? 'l' : 'u')
                : locationFlagged ? (direction == 'u' ? 'd' : direction == 'r' ? 'l' : direction == 'd' ? 'u' : 'r')
                : locationWeak ? direction
                : (direction == 'u' ? 'l' : direction == 'l' ? 'd' : direction == 'd' ? 'r' : 'u');
            var nextInfectionLocations = locationInfected ? infectedLocations.Remove(location)
                : locationWeak ? infectedLocations.Add(location)
                : infectedLocations;
            var nextWeakLocations = locationWeak ? weakLocations.Remove(location)
                : locationClean ? weakLocations.Add(location)
                : weakLocations;
            var nextFlaggedLocations = locationFlagged ? flaggedLocations.Remove(location)
                : locationInfected ? flaggedLocations.Add(location)
                : flaggedLocations;
            var nextRow = nextDirection == 'd' ? location.Row + 1
                : nextDirection == 'u' ? location.Row - 1
                : location.Row;
            var nextCol = nextDirection == 'r' ? location.Column + 1
                : nextDirection == 'l' ? location.Column - 1
                : location.Column;

            return (nextInfectionLocations, nextWeakLocations, nextFlaggedLocations, (nextRow, nextCol), nextDirection, locationWeak);
        }

        private static long Day23Part1(string input)
        {
            var instructions = Program.Day18ReadInstructions(input);

            return EnumerableExtensions
                .TupleGenerate(
                    0,
                    ImmutableDictionary<char, long>.Empty,
                    (instructionPointer, __) => instructionPointer < instructions.Length,
                    (instructionPointer, registers) => Program.Day23ExecuteInstruction(
                        instructions,
                        instructionPointer,
                        registers))
                .Count(t => instructions[t.Item1].Instruction == "mul");
        }

        private static Tuple<int, ImmutableDictionary<char, long>> Day23ExecuteInstruction(
            ImmutableArray<(string Instruction, string X, string Y)> instructions,
            int instructionPointer,
            ImmutableDictionary<char, long> registers)
        {
            var instruction = instructions[instructionPointer];
            var nextInstructionPointer = instructionPointer + 1;
            var nextRegisters = registers;

            switch (instruction.Instruction)
            {
                case "set":
                {
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    nextRegisters = registers.UpdateValue(instruction.Item2[0], 0, _ => valueOfY);
                    break;
                }
                case "sub":
                {
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    nextRegisters = registers.UpdateValue(instruction.Item2[0], 0, x => x - valueOfY);
                    break;
                }
                case "mul":
                {
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    nextRegisters = registers.UpdateValue(instruction.Item2[0], 0, x => x * valueOfY);
                    break;
                }
                case "jnz":
                {
                    var valueOfX = Program.Day18ValueOfX(registers, instruction);
                    var valueOfY = Program.Day18ValueOfY(registers, instruction);
                    if (valueOfX != 0)
                    {
                        nextInstructionPointer = (int) (instructionPointer + valueOfY);
                    }
                    break;
                }
                default:
                    throw new InvalidOperationException($"Got invalid instruction: {instruction}");
            }

            return Tuple.Create(nextInstructionPointer, nextRegisters);
        }

        private static long Day23Part2(string input)
        {
            // Program is too slow as-is, so it has to be decompiled. The
            // program determines the number of non-primes from 106700 to
            // 123700.

            // var instructions = Program.Day18ReadInstructions(input);

            // var finalRegisters = EnumerableExtensions
            //     .TupleGenerate(
            //         0,
            //         ImmutableDictionary<char, long>.Empty.Add('a', 1),
            //         (instructionPointer, __) => instructionPointer < instructions.Length,
            //         (instructionPointer, registers) => Program.Day23ExecuteInstruction(
            //             instructions,
            //             instructionPointer,
            //             registers))
            //     .Last();

            // return finalRegisters.Item2.GetValueOrDefault('h', 0);

            return EnumerableExtensions
                .Generate(106700, num => num <= 123700, num => num + 17)
                .Count(number => !Program.Day23IsPrime(number));
        }

        private static bool Day23IsPrime(int number)
        {
            var end = (int) Math.Sqrt(number);

            return EnumerableExtensions
                .Generate(3, divisor => divisor <= end, divisor => divisor + 2)
                .StartWith(2)
                .All(divisor => number % divisor != 0);
        }

        private static int Day24Part1(string input)
        {
            var components = Program.Day24ReadComponents(input);

            var strongestBridge = Program.Day24GetStrongestBridge(0, components, ImmutableHashSet<int>.Empty);

            return strongestBridge.Strength;
        }

        private static ImmutableDictionary<int, ImmutableArray<(int Left, int Right, string Part, int Id)>> Day24ReadComponents(string input)
        {
            var components = input
                .SelectLines()
                .Select((line, index) =>
                {
                    var parts = line.Split("/");
                    return (
                        Left: int.Parse(parts[0]),
                        Right: int.Parse(parts[1]),
                        Part: line,
                        Id: index);
                })
                .SelectMany(t => t.Left == t.Right
                    ? new[] {t}
                    : new[] {t, (Left: t.Right, Right: t.Left, t.Part, t.Id)})
                .GroupBy(t => t.Left)
                .ToImmutableDictionary(g => g.Key, g => g.ToImmutableArray());
            return components;
        }

        private static (int Strength, ImmutableList<string> Components) Day24GetStrongestBridge(
            int lastPort,
            ImmutableDictionary<int, ImmutableArray<(int Left, int Right, string Part, int Id)>> components,
            ImmutableHashSet<int> usedComponents)
        {
            var candidates = components.GetValueOrDefault(lastPort, ImmutableArray<(int Left, int Right, string Part, int Id)>.Empty)
                .Where(t => !usedComponents.Contains(t.Id))
                .ToImmutableArray();

            if (candidates.IsEmpty)
            {
                return (0, ImmutableList<string>.Empty);
            }

            var selected = default(string);
            var selectedResult = (Strength: 0, Components: ImmutableList<string>.Empty);
            foreach (var component in candidates)
            {
                var result = Program.Day24GetStrongestBridge(component.Right, components, usedComponents.Add(component.Id));

                var totalStrength = result.Strength + component.Left + component.Right;
                if (selected == null || totalStrength > selectedResult.Strength)
                {
                    selected = component.Part;
                    selectedResult = (
                        totalStrength,
                        result.Components.Insert(0, component.Part)
                    );
                }
            }

            return selectedResult;
        }

        private static int Day24Part2(string input)
        {
            var components = Program.Day24ReadComponents(input);

            var longestBridge = Program.Day24GetLongestBridge(0, components, ImmutableHashSet<int>.Empty);

            return longestBridge.Strength;
        }

        private static (int Strength, ImmutableList<string> Components) Day24GetLongestBridge(
            int lastPort,
            ImmutableDictionary<int, ImmutableArray<(int Left, int Right, string Part, int Id)>> components,
            ImmutableHashSet<int> usedComponents)
        {
            var candidates = components.GetValueOrDefault(lastPort, ImmutableArray<(int Left, int Right, string Part, int Id)>.Empty)
                .Where(t => !usedComponents.Contains(t.Id))
                .ToImmutableArray();

            if (candidates.IsEmpty)
            {
                return (0, ImmutableList<string>.Empty);
            }

            var selected = default(string);
            var selectedResult = (Strength: 0, Components: ImmutableList<string>.Empty);
            foreach (var component in candidates)
            {
                var result = Program.Day24GetLongestBridge(component.Right, components, usedComponents.Add(component.Id));

                var totalLength = result.Components.Count + 1;
                if (selected == null || totalLength > selectedResult.Components.Count)
                {
                    selected = component.Part;
                    selectedResult = (
                        result.Strength + component.Left + component.Right,
                        result.Components.Insert(0, component.Part)
                    );
                }
            }

            return selectedResult;
        }

        private static int Day25Part1(string input)
        {
            var (startState, stepCount, states) = Program.Day25ReadMachine(input);

            var finalState = EnumerableExtensions
                .TupleGenerate(
                    startState,
                    ImmutableHashSet<int>.Empty,
                    0,
                    (_, __, ___) => true,
                    (lastState, tape, location) =>
                    {
                        var value = tape.Contains(location) ? 1 : 0;
                        var action = states[lastState][value];
                        return Tuple.Create(
                            action.NextState,
                            action.Write == 1 ? tape.Add(location) : tape.Remove(location),
                            action.Move == 'r' ? location + 1 : location - 1);
                    })
                .Skip(stepCount)
                .First();

            return finalState.Item2.Count;
        }

        private static (char StartState, int StepCount, ImmutableDictionary<char, (int Write, char Move, char NextState)[]> States) Day25ReadMachine(string input)
        {
            var lines = input
                .SelectLines()
                .ToImmutableArray();

            var startState = lines[0][15];
            var stepCount = int.Parse(lines[1].Split(" ")[5]);

            var states = lines
                .Skip(2)
                .Batch(9)
                .Select(linesForState =>
                {
                    var state = linesForState[0][9];

                    var ifZeroWrite = linesForState[2][22] == '1' ? 1 : 0;
                    var ifZeroMove = linesForState[3][27];
                    var ifZeroNextState = linesForState[4][26];

                    var ifOneWrite = linesForState[6][22] == '1' ? 1 : 0;
                    var ifOneMove = linesForState[7][27];
                    var ifOneNextState = linesForState[8][26];

                    return (
                        State: state,
                        Actions: new[] {
                            (
                                Write: ifZeroWrite,
                                Move: ifZeroMove,
                                NextState: ifZeroNextState
                            ),
                            (
                                Write: ifOneWrite,
                                Move: ifOneMove,
                                NextState: ifOneNextState
                            )
                        }
                    );
                })
                .ToImmutableDictionary(t => t.State, t => t.Actions);

            return (
                StartState: startState,
                StepCount: stepCount,
                States: states);
        }

    }
}
