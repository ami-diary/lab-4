using System;

namespace Lab4_MaxElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            double[] arr = new double[n];
            Random rnd = new Random();

            Console.WriteLine("Сгенерированный массив:");

            for (int i = 0; i < n; i++)
            {
                arr[i] = Math.Round(rnd.NextDouble() * 20 - 10, 2); // от -10 до 10
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            int maxIndex = 0;
            double maxValue = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine($"\nПервый максимальный элемент: {maxValue}");
            Console.WriteLine($"Его номер (индекс): {maxIndex}");

            Console.ReadKey();
        }
    }
}