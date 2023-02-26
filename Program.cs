using System;
using System.Threading;

namespace Module_9_3_4
{
    class Program
    {
        public delegate void SubstractSumDelegate(int a, int b);

        static void Main(string[] args)
        {
            SubstractSumDelegate substractSumDelegate = Substract;
            substractSumDelegate += Sum;
            substractSumDelegate(10, 5);
            
            Console.ReadKey();
        }

        static void Substract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}