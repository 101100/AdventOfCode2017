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
                const string input = Inputs.Day4;

                Console.WriteLine($"Part 1: {Day4Part1(input)}");
                Console.WriteLine($"Part 2: {Day4Part2(input)}");
            }
            else if (day == 5)
            {
                const string input = Inputs.Day5;

                Console.WriteLine($"Part 1: {Day5Part1(input)}");
                Console.WriteLine($"Part 2: {Day5Part2(input)}");
            }
            else if (day == 6)
            {
                const string input = Inputs.Day6;

                Console.WriteLine($"Part 1: {Day6Part1(input)}");
                Console.WriteLine($"Part 2: {Day6Part2(input)}");
            }
            else if (day == 7)
            {
                const string input = Inputs.Day7;

                Console.WriteLine($"Part 1: {Day7Part1(input)}");
                Console.WriteLine($"Part 2: {Day7Part2(input)}");
            }
            else if (day == 8)
            {
                const string input = Inputs.Day8;

                Console.WriteLine($"Part 1: {Day8Part1(input)}");
                Console.WriteLine($"Part 2: {Day8Part2(input)}");
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
                .Select(row => row.Max() - row.Min())
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
                    .Any(g => g.Count() > 1))
                .Count(invalid => !invalid);
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
                    .Any(g => g.Count() > 1))
                .Count(invalid => !invalid);
        }

        private static int Day5Part1(string input)
        {
            var startingCode = input
                .Split("\n")
                .Select(r => int.Parse(r.Trim()))
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
                .Split("\n")
                .Select(r => int.Parse(r.Trim()))
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
                    lastState => Tuple.Create(lastState.Item1.Add(string.Join(":", lastState.Item2)), Day6Redistribute(lastState.Item2)))
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
                    lastState => Tuple.Create(lastState.Item1.SetItem(string.Join(":", lastState.Item2), lastState.Item1.GetValueOrDefault(string.Join(":", lastState.Item2), 0) + 1), Day6Redistribute(lastState.Item2)))
                .Select((t, index) => Tuple.Create(string.Join(":", t.Item2), index))
                .Aggregate(ImmutableDictionary<string, ImmutableList<int>>.Empty,
                    (acc, tuple) => acc.SetItem(
                        tuple.Item1,
                        acc.GetValueOrDefault(tuple.Item1, ImmutableList<int>.Empty).Add(tuple.Item2)))
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
                .Split("\n")
                .Select(r => r.Trim())
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
                .Split("\n")
                .Select(r => r.Trim())
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

            return Day7FindUnbalancedNodesCorrectWeight(root);
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
                var result = Day7FindUnbalancedNodesCorrectWeight(child);
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
                .Split("\n")
                .Select(r => r.Trim())
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
                        return Day8CheckCondition(registers.GetValueOrDefault(parsed.Item3, 0), parsed.Item4, parsed.Item5)
                            ? registers.UpdateValue(parsed.Item1, 0, val => val + parsed.Item2)
                            : registers;
                    })
                .Select(p => p.Value)
                .Max();
        }

        private static int Day8Part2(string input)
        {
            return input
                .Split("\n")
                .Select(r => r.Trim())
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
                        return Day8CheckCondition(registers.GetValueOrDefault(parsed.Item3, 0), parsed.Item4, parsed.Item5)
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

    }
}
