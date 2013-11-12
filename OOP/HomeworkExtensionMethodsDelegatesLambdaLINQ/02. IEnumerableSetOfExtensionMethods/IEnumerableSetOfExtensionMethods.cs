namespace IEnumerableSetOfExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //Implement a set of extension methods for IEnumerable<T> that implement 
    //the following group functions: sum, product, min, max, average.

    public static class IEnumerableSetOfExtensionMethods
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic result = null;
            foreach (var item in collection)
            {
                result += item;
            }
            return result;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic result = null;
            foreach (var item in collection)
            {
                result *= item;
            }
            return result;
        }

        public static T Min<T>(this IEnumerable<T> collection)
        {
            dynamic result = decimal.MaxValue;
            foreach (var item in collection)
            {
                if (item < result)
                {
                    result = item;
                }
            }
            return result;
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            dynamic result = decimal.MinValue;
            foreach (var item in collection)
            {
                if (item > result)
                {
                    result = item;
                }
            }
            return result;
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            dynamic result = null;
            dynamic denominator = 0;
            foreach (var item in collection)
            {
                result += item;
                denominator++;
            }
            result /= denominator;
            return result;
        }
    }
}