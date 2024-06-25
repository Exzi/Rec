using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintArrayReverse(array, array.Length - 1);
        }

        static void PrintArrayReverse(int[] array, int index)
        {
            if (index < 0) return;
            Console.Write(array[index] + " ");
            PrintArrayReverse(array, index - 1);
        }
    }
}