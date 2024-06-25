using System;

namespace Ackermann
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение m (не более 3):");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение n (не более 10):");
            int n = int.Parse(Console.ReadLine());

            if (m > 3 || n > 10)
            {
                Console.WriteLine("Значения m и n слишком большие для корректной работы функции Аккермана.");
                return;
            }

            int result = Ackermann(m, n);
            Console.WriteLine($"Ackermann({m}, {n}) = {result}");
        }

        static int Ackermann(int m, int n)
        {
            if (m == 0) return n + 1;
            if (m > 0 && n == 0) return Ackermann(m - 1, 1);
            if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
            return -1; // This should never be reached
        }
    }
}
