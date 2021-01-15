
using System;
using structures_and_algorithms.Algorithms.Levenstain_distance;
using structures_and_algorithms.Algorithms.Fast_Pow;
using structures_and_algorithms.LInkedList;
using structures_and_algorithms.Algorithms.Sort;
using structures_and_algorithms.Algorithms.Search;
using System.Collections.Generic;
using structures_and_algorithms.Algorithms;

namespace structures_and_algorithms
{
    class Program
    { 
        static void Main(string[] args)
        {
            string line = Environment.NewLine;
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
                    Console.WriteLine($"{i} in {i + 2} ={Pow.Iter(i, i + 2)}");
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

            RandomInt32Array rnd = new RandomInt32Array(50,-10,25);
            var TestArr=rnd.Array;
            Console.WriteLine("Search");
            Console.WriteLine(line);
            Console.WriteLine("Maximum ind: "+ TestArr.IndOfMaximum());
            Console.WriteLine("Minimum ind: " + TestArr.IndOfMinimum());
            Console.WriteLine("Maximum: " + TestArr.MaximumVal());
            Console.WriteLine("Minimum: " + TestArr.MinimumVal());
            Console.WriteLine(line);
            QuickSort QS = new QuickSort();
            TestArr=QS.Sort(TestArr);
            Console.WriteLine("TestArray 5 index " + BinarySearch.BinSearch(TestArr, 5, 0, TestArr.Length-1));
            Console.WriteLine(line);
            Console.WriteLine("Поиск длиннейшей общей подстроки. Введите два слова ниже");
            Console.WriteLine("Общая подстрока: "+ LongestComonString.Search(Console.ReadLine(), Console.ReadLine())); 
            Console.ReadLine();
        }
    }
}
