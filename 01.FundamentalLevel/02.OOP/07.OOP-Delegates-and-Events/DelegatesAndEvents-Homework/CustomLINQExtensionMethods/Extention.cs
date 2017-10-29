namespace CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extention
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (var element in collection)
            {
                if (!predicate(element))
                {
                    result.Add(element);
                }
            }

            return result;
        }

        public static TSelector Max<TSource, TSelector>(
            this IEnumerable<TSource> collection, Func<TSource, TSelector> selector)
            where TSelector : IComparable
        {
            TSelector result = selector(collection.First());

            foreach (var element in collection)
            {
                if (result.CompareTo(selector(element)) < 0)
                {
                    result = selector(element);
                }
            }

            return result;
        }
    }
}
