
using System;
using structures_and_algorithms.Algorithms.Levenstain_distance;
using structures_and_algorithms.Algorithms.Fast_Pow;
using structures_and_algorithms.LInkedList;
using structures_and_algorithms.Algorithms.Sort;

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
                LinkedList<string> LList = new LinkedList<string>();
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
                Console.WriteLine("Unsorted array:");
                var numbersArr = new int[15];
                Random rnd = new Random();
                for(Int32 i = 0; i < numbersArr.Length; i++)
                {
                    numbersArr[i] = rnd.Next(-5,5);
                    Console.Write(numbersArr[i]+" ");
                }
                Console.WriteLine();

                /*Console.WriteLine("Sorted array: {0}",string.Join(", ", RandomSort.Sort(numbersArr)));*/ //Can`t work with big range

                Console.WriteLine("Sorted array Tree: {0}", string.Join(", ", TreeSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array Combo: {0}", string.Join(", ", CombSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array Gnome: {0}", string.Join(", ", CountingSort.Sort(numbersArr, 9)));//error
                Console.WriteLine("Sorted array Bubble: {0}", string.Join(", ", BubbleSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array Coctail: {0}", string.Join(", ", CocktailSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array Insertion: {0}", string.Join(", ", InsertionSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array Stooge: {0}", string.Join(", ", StoogeSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array Pancake: {0}", string.Join(", ", PancakeSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array Shell: {0}", string.Join(", ", ShellSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array Merge: {0}", string.Join(", ", MergeSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array Selection: {0}", string.Join(", ", SelectionSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array Quick: {0}", string.Join(", ", QuickSort.Sort(numbersArr)));
                Console.WriteLine("Sorted array Gnome: {0}", string.Join(", ", GnomeSort.Sort(numbersArr)));

                Console.WriteLine(line);
            }
            
            Console.ReadLine();
        }
    }
}
