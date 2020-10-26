using structures_and_algorithms.Algorithms.Fast_Pow;
using structures_and_algorithms.LInkedList;
using structures_and_algorithms.Algorithms;
using System;
using System.Security.Cryptography.X509Certificates;

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
            Console.ReadLine();
        }
    }
}
