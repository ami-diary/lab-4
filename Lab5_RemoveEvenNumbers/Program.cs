using System;
using System.Collections.Generic;

namespace Lab5_RemoveEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Random rand = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-10, 11);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n");

            // Удаляем чётные элементы
            List<int> oddNumbers = new List<int>();
            foreach (int num in array)
            {
                if (num % 2 != 0)
                    oddNumbers.Add(num);
            }

            Console.WriteLine("Массив без чётных чисел:");
            foreach (int num in oddNumbers)
                Console.Write(num + " ");

            Console.WriteLine();
        }
    }
}