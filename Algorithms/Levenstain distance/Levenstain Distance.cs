using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using structures_and_algorithms.Algorithms;

namespace structures_and_algorithms.Algorithms.Levenstain_distance
{
  public static  class Levenstain_Distance
    {
        public static int Find(string FWord,string SWord, bool Damerau=false)
        {
            var n = FWord.Length+1;
            var m = SWord.Length + 1;
            var matrix = new int[n,m];
            const int deletionCost = 1;
            const int insertionCost = 1;
            for (int i=0;i<n;i++)
            {
                matrix[i, 0] = i;
            }
            for (int j=0;j<m;j++)
            {
                matrix[0, j] = j;
            }
            for (int i=1;i<n;i++)
            {
                for (int j=1;j<m;j++)
                {
                    var substrCost = FWord[i - 1] == SWord[j - 1] ? 0 : 1;
                    matrix[i, j] = Minimum.Find(
                        matrix[i-1,j]+deletionCost,
                        matrix[i,j-1]+insertionCost,
                        matrix[i-1,j-1]+substrCost);
                    if (Damerau == true)
                    {
                        if (i > 1 && j > 1
                        && FWord[i - 1] == SWord[j - 2]
                        && FWord[i - 2] == SWord[j - 1])
                        {
                            matrix[i, j] = Minimum.Find(matrix[i, j],
                                matrix[i - 2, j - 2] + substrCost);
                        }
                    }
                    
                }
            }
           
            return matrix[n - 1, m - 1];
        }
    }
}
