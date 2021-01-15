using System;
using System.Collections.Generic;
using System.Text;

namespace structures_and_algorithms.Algorithms.Search
{
    public static class LongestComonString
    {/// <summary>
     /// Поиск наибольшей общей подстроки
     /// </summary>
        public static string Search(string Word_1,string Word_2)
        {
            var n = Word_1.Length;
            var m = Word_2.Length;
            var array = new int[n,m];
            var maxVal = 0;
            var maxI = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (Word_1[i]==Word_2[j])
                    {
                        array[i, j] = (i == 0 || j == 0) ?
                            1 :
                            array[i - 1, j - 1] + 1;
                        if (array[i,j]>maxVal)
                        {
                            maxVal = array[i, j];
                            maxI = i;
                        }
                    }
                    
                }
            }
            return Word_1.Substring(maxI+1-maxVal,maxVal);
        }
    }
}
