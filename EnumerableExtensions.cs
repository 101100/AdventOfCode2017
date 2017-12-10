using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> input, int batchSize)
        {
            var inputArray = input.ToImmutableArray();

            for (var start = 0; start < inputArray.Length; start += batchSize)
            {
                yield return inputArray.Skip(start).Take(batchSize);
            }

            var remainder = inputArray.Length % batchSize;
            if (remainder > 0)
            {
                yield return inputArray.Skip(inputArray.Length - remainder);
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

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> input, int repetitions)
        {
            return Enumerable
                .Range(0, repetitions)
                .SelectMany(_ => input);
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

        public static IEnumerable<Tuple<T1, T2, T3, T4, T5>> TupleScan<TInput, T1, T2, T3, T4, T5>(
            this IEnumerable<TInput> input,
            T1 seed1,
            T2 seed2,
            T3 seed3,
            T4 seed4,
            T5 seed5,
            Func<T1, T2, T3, T4, T5, TInput, Tuple<T1, T2, T3, T4, T5>> update)
        {
            var state = Tuple.Create(seed1, seed2, seed3, seed4, seed5);

            foreach (var item in input)
            {
                state = update(state.Item1, state.Item2, state.Item3, state.Item4, state.Item5, item);
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
