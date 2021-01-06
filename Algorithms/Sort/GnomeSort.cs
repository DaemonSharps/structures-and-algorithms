using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Sort
{
    public class GnomeSort:ISort
    {
        public Int32[] Sort(Int32[] arr)
        {
            var index = 1;
            var nextIndex = index++;
            while (index<arr.Length)
            {
                if (arr[index-1]<arr[index])
                {
                    index=nextIndex;
                    nextIndex++;
                }
                else
                {
                    Swap.Go(ref arr[index-1], ref arr[index]);
                    index--;
                    if (index==0)
                    {
                        index = nextIndex;
                        nextIndex++;
                    }
                }

            }
            return arr;
        }
    }
}
