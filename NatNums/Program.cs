using System;
namespace NatNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Значение M:");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("Значение N:");
            int N = int.Parse(Console.ReadLine());

            PrintNatNums(M, N);
        }

        static void PrintNatNums(int M, int N)
        {
            if (M > N) return;
            Console.Write(M + " ");
            PrintNatNums(M + 1, N);
        }
    }
}