using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort.Additional
{
    public static class SortTest
    {
        public static bool IsSortedLeftToRight<TSource>(this IList<TSource> data) where TSource:IComparable
        {
            for (int i = 0; i < data.Count-1; i++)
            {
                if(data[i].CompareTo(data[i+1])>0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
