using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Search
{
    public static class BinarySearch
    {public static Int32 BinSearch(Int32[] arr,Int32 SearchedVal, Int32 first, Int32 last)
        {
            if (first>last)
            {
                return -1;
            }
            var middle = (first + last) / 2;
            var middleVal = arr[middle];
            if (middleVal==SearchedVal)
            {
                return middle;
            }
            else
            {
                if (middleVal>SearchedVal)
                {
                    return BinSearch(arr,SearchedVal,first,middle-1);
                }
                else
                {
                    return BinSearch(arr, SearchedVal, middle + 1, last);
                }
            }
        }
    }
}
