using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Fibbonanci
{
    class Program
    {
        static List<int> intlstrecursive = new List<int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = Convert.ToInt32(Console.ReadLine());
            CalculateFibonacci(n);
        }

        public static void CalculateFibonacci(int number)
        {
            List<int> intlst = new List<int>();
            int a = 0, b = 1, c;

            intlst.Add(b);
            for (int i = 1; i < number; i++)
            {
                c = a + b;
                intlst.Add(c);
                a = b;
                b = c;
            }

            //foreach(int data in intlst)
            //{
            //    Console.Write(data +  " ");
            //}

            Console.WriteLine(intlst.Aggregate((x,y) => x * y));
        }
    }
}
