using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Search
{
    public static class ArraysExtentions
    {
        private static void CheckArray<T>(T[] a)
        {
            if (a == null)
            {
                throw new ArgumentNullException("Array must be not null");
            }
            if (a.Length == 0)
            {
                throw new ArgumentException("Array length must be more than zero");
            }
        }
        public static Int32 linSearch<T>(this T[] a, T key) where T : struct, IEquatable<T>
        {
            CheckArray(a);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Equals(key))
                {
                    return i;
                }
            }
            return -1;
        }
        public static Int32 IndOfMinimum<T>(this T[] a) where T : struct, IComparable<T>
        {
            CheckArray(a);
            var iMin = 0;
            T Min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].CompareTo(Min) < 0)
                {
                    Min = a[i];
                    iMin = i;
                }
            }
            return iMin;
        }
        public static T MinimumVal<T>(this T[] a) where T : struct, IComparable<T>
        {
            CheckArray(a);
            T min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].CompareTo(min) < 0)
                {
                    min = a[i];
                }
            }
            return min;
        }
        public static Int32 IndOfMaximum<T>(this T[] a) where T : struct, IComparable<T>
        {
            CheckArray(a);
            var iMax = 0;
            T Max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].CompareTo(Max) > 0)
                {
                    Max = a[i];
                    iMax = i;
                }
            }
            return iMax;
        }
        public static T MaximumVal<T>(this T[] a) where T : struct, IComparable<T>
        {
            CheckArray(a);
            T max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].CompareTo(max) > 0)
                {
                    max = a[i];
                }
            }
            return max;
        }
    }
}
