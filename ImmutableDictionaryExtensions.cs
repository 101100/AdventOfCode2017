using System;
using System.Collections.Immutable;

namespace AdventOfCode2017
{
    public static class ImmutableDictionaryExtensions
    {

        public static ImmutableDictionary<TKey, TValue> UpdateValue<TKey, TValue>(
            this ImmutableDictionary<TKey, TValue> dictionary,
            TKey key,
            TValue defaultInitialValue,
            Func<TValue, TValue> updater)
        {
            return dictionary.SetItem(key, updater(dictionary.GetValueOrDefault(key, defaultInitialValue)));
        }

    }
}
