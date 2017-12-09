using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<Tuple<T, T>> AllPairs<T>(this IEnumerable<T> input)
        {
            var inputArray = input.ToArray();

            for (var i = 0; i < inputArray.Length; i++)
            {
                for (var j = i + 1; j < inputArray.Length; j++)
                {
                    yield return Tuple.Create(inputArray[i], inputArray[j]);
                }
            }
        }

        public static IEnumerable<T> Debug<T>(this IEnumerable<T> input, string label = null, Func<T, string> printer = null)
        {
            foreach (var item in input)
            {
                Console.WriteLine($"{label ?? "Got value"}: '{(printer == null ? item.ToString() : printer(item))}'");
                yield return item;
            }
        }

        public static IEnumerable<T> Generate<T>(T seed, Func<T, bool> predicate, Func<T, T> iterate)
        {
            var next = seed;
            while (predicate(next))
            {
                yield return next;
                next = iterate(next);
            }
        }

        public static IEnumerable<Tuple<T, T>> PairWise<T>(this IEnumerable<T> input)
        {
            var last = default(T);
            var first = true;
            foreach (var next in input)
            {
                if (!first)
                {
                    yield return Tuple.Create(last, next);
                }
                last = next;
                first = false;
            }
        }

        public static IEnumerable<TScan> Scan<TInput, TScan>(
            this IEnumerable<TInput> input,
            TScan seed,
            Func<TScan, TInput, TScan> update)
        {
            var state = seed;

            foreach (var item in input)
            {
                state = update(state, item);
                yield return state;
            }
        }

        public static IEnumerable<T> StartWith<T>(this IEnumerable<T> input, T item)
        {
            return new[] {item}
                .Concat(input);
        }

    }
}
