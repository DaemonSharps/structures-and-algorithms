using System;
using System.Collections.Generic;
using structures_and_algorithms.Algorithms.Sort.Additional;
namespace structures_and_algorithms.Algorithms.Sort
{
    public static class SortStarter
    {
        public static void Start(List<ISort> SortClasses)
        {
            foreach (var Sort in SortClasses)
            {
                Console.WriteLine("Unsorted array:");
                RandomInt32Array rndia = new RandomInt32Array(15);
                var numbersArr = rndia.Array;
                Console.WriteLine();
                System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
                Console.WriteLine("Sorted array {1}: {0}, sorted OK: {2}", string.Join(", ",numbersArr= Sort.Sort(numbersArr)), Sort.GetType(),numbersArr.IsSortedLeftToRight());
                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: {0}",stopwatch.ElapsedTicks+Environment.NewLine);
                
            }
        }
    }
}
