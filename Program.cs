using structures_and_algorithms.Algorithms.Fast_Pow;
using structures_and_algorithms.LInkedList;
using structures_and_algorithms.Algorithms.Sort;
using System;
using System.Security.Cryptography.X509Certificates;
using structures_and_algorithms.Algorithms.Levenstain_distance;

namespace structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                LinkedList<string> LList = new LinkedList<string>();
                LList.Add("dashulya");
                LList.Add("Deniska");
                foreach (string s in LList)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine(LList.contains("dashulya"));
                Console.WriteLine(LList.contains("Dens"));
            }
            {
                for (int i=0;i<5;i++)
                {
                    Console.WriteLine($"{i} in {i*2} ={Pow.Recursive(i, i * 2)}");
                    Console.WriteLine($"{i} in {i + 2} ={Pow.Iter(i, i * 2)}");
                    Console.WriteLine($"{i} in {15} ={Pow.Byte(i, 15)}");
                }
            }
            {
                Console.Write("Enter First word"); var s1 = Console.ReadLine();
                Console.Write("Enter Second word"); var s2 = Console.ReadLine();
                Console.WriteLine($"Расстояние Левенштейна для слов {s1} и {s2} равно {Levenstain_Distance.Find(s1,s2 )}");
                Console.WriteLine($"Расстояние Левенштейна для слов {s1} и {s2} равно {Levenstain_Distance.Find(s1, s2,true)}");
            }
            {
                Console.WriteLine("Enter numbers");
               var entNums= Console.ReadLine().Split(new[] { " ", ",", ";" },StringSplitOptions.RemoveEmptyEntries);
                var numbersArr = new int[entNums.Length];
                for (int i=0;i<entNums.Length;i++)
                {
                    numbersArr[i] = Convert.ToInt32(entNums[i]);
                }
                Console.WriteLine("Sorted array: {0}",string.Join(", ", RandomSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array: {0}", string.Join(", ", BubbleSort.Sort(numbersArr)));

            }
            
            Console.ReadLine();
        }
    }
}
