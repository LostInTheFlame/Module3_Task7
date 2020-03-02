using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
            {
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Введите {i+1}-й элемент массива: ");
                    if (!int.TryParse(Console.ReadLine(), out array[i])) 
                    {
                        Console.WriteLine("\nОшибка при вводе значения.");
                        Console.ReadKey(true);
                        return;
                    }
                }
                Console.WriteLine("\nРезультат: ");
                for (int i = 1; i < size; i++)
                {
                    if (array[i] > array[i-1])
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nОшибка при вводе значения.");
            }
            Console.ReadKey(true);
        }
    }
}
