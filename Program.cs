
using System;
using structures_and_algorithms.Algorithms.Levenstain_distance;
using structures_and_algorithms.Algorithms.Fast_Pow;
using structures_and_algorithms.LInkedList;
using structures_and_algorithms.Algorithms.Sort;
using System.Collections.Generic;

namespace structures_and_algorithms
{
    class Program
    { 
        static void Main(string[] args)
        {
            string line = "_____________________________";
            {
                Console.WriteLine("Linked List");

                Console.WriteLine(line);
                MyLinkedList<string> LList = new MyLinkedList<string>();
                LList.Add("dashulya");
                LList.Add("Deniska");
                foreach (string s in LList)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine($"Llist contains dashulya: {LList.contains("dashulya")}");
                Console.WriteLine($"Llist contains Dens: {LList.contains("Dens")}");
                Console.WriteLine(line);
            }
            {
                Console.WriteLine("Fast Pow");
                Console.WriteLine(line);
                for (int i=0;i<5;i++)
                {
                    Console.WriteLine($"{i} in {i*2} ={Pow.Recursive(i, i * 2)}");
                    Console.WriteLine($"{i} in {i + 2} ={Pow.Iter(i, i * 2)}");
                    Console.WriteLine($"{i} in {15} ={Pow.Byte(i, 15)}");
                }
                Console.WriteLine(line);
            }
            {
                Console.WriteLine("Levenstain distance");
                Console.WriteLine(line);
                Console.Write("Enter First word"); var s1 = Console.ReadLine();
                Console.Write("Enter Second word"); var s2 = Console.ReadLine();
                Console.WriteLine($"Расстояние Левенштейна для слов {s1} и {s2} равно {Levenstain_Distance.Find(s1,s2 )}");
                Console.WriteLine($"Расстояние Левенштейна для слов {s1} и {s2} равно {Levenstain_Distance.Find(s1, s2,true)}");
                Console.WriteLine(line);
            }
            {
                Console.WriteLine("Sorts");
                Console.WriteLine(line);
                /*  Console.WriteLine("Enter numbers");
                 var entNums= Console.ReadLine().Split(new[] { " ", ",", ";" },StringSplitOptions.RemoveEmptyEntries);
                  var numbersArr = new int[entNums.Length];
                  for (int i=0;i<entNums.Length;i++)
                  {
                      numbersArr[i] = Convert.ToInt32(entNums[i]);
                  }*/


                /*Console.WriteLine("Sorted array: {0}",string.Join(", ", RandomSort.Sort(numbersArr)));*/ //Can`t work with big range
                List<ISort> Sorts = new List<ISort>() {
                    new BubbleSort(),
                    new CocktailSort(),
                    new CombSort(),
                    new CountingSort(),
                    new GnomeSort(),
                    new InsertionSort(),
                    new MergeSort(),
                    new PancakeSort(),
                    new QuickSort(),
                    new SelectionSort(),
                    new ShellSort(),
                    new StoogeSort(),
                    new TreeSort()
                };
                SortStarter.Start(Sorts);
                Console.WriteLine(line);
            }
            
            Console.ReadLine();
        }
    }
}
