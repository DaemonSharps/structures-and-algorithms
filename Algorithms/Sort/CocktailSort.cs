using System;


namespace structures_and_algorithms.Algorithms.Sort
{
  public static  class CocktailSort
    {
      public  static Int32[] Sort(Int32[] arr)
        {
            
            for (int i = 0; i < arr.Length/2; i++)
            {
                var SwapFlag = false;
                for (int j = i; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        
                    {
                        Swap.Go(ref arr[j], ref arr[j + 1]);
                        SwapFlag = true;
                    }
                }
                for (int j = arr.Length-2-i; j > i; j--)
                {
                    if (arr[j-1]>arr[j])
                    {
                        Swap.Go(ref arr[j-1],ref arr[j]);
                        SwapFlag = true;
                    }
                }
                if(!SwapFlag)
                {
                    break;
                }
            }
            return arr;
        }
    }
}
