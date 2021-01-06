using System;

namespace structures_and_algorithms.Algorithms.Sort
{
  public class MergeSort:ISort
    { 
        static void Merge(Int32[] arr,Int32 lIndex,Int32 mIndex,Int32 hIndex)
        {
            var left = lIndex;
            var right = mIndex + 1;
            var tempArr = new Int32[hIndex - lIndex + 1];
            var ind = 0;
            while ((left<=mIndex)&&(right<=hIndex))
            {
                if (arr[left]<arr[right])
                {
                    tempArr[ind] = arr[left];
                    left++;
                }
                else
                {
                    tempArr[ind] = arr[right];
                    right++;
                }
                ind++;
            }
            for (int i = left; i <= mIndex; i++)
            {
                tempArr[ind] = arr[i];
                ind++;
            }
            for (int i = right; i <= hIndex; i++)
            {
                tempArr[ind] = arr[i];
                ind++;
            }
            for (int i = 0; i < tempArr.Length; i++)
            {
                arr[lIndex+i] = tempArr[i];
            }
        }
        static Int32[] MergeSrt(Int32[] arr, Int32 lowI,Int32 highI)
        {
            if (lowI<highI)
            {
                var midleI = (lowI+highI) / 2;
                MergeSrt(arr,lowI,midleI);
                MergeSrt(arr,midleI+1,highI);
                Merge(arr,lowI,midleI,highI);
            }
            return arr;
        }
        public Int32[] Sort(Int32[] arr)
        {
            return MergeSrt(arr,0,arr.Length-1);
        }
    }
}
