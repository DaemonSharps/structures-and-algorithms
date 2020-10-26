using structures_and_algorithms.LInkedList;
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
            
            Console.ReadLine();
        }
    }
}
