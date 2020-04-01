/*
 * Developed by Faridun Berdiev
 * Date: 01.04.2020
 * Third Task
*/
using System;

namespace Task_3
{
    class Program
    {
        static void ExecuteThirdTask(int elCount)
        {
            int[] arr = new int[elCount];
            for (int i = 0; i < elCount; i++)
            {
                arr[i] = new Random().Next(50, 100);
            }

            Array.ForEach(arr, item => {
                Console.WriteLine(item);
            });

            Console.Write("Введите (count): ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Введите (index): ");
            int index = int.Parse(Console.ReadLine());
            
            int[] arr1 = new int[count];
            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = 1;
            }
            for(int i = index, j = 0; j <= count; i++, j++)
            {
                try
                {
                    arr1[j] = arr[i];
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
                    
            }
            
            Array.ForEach(arr1, item => {
                Console.WriteLine(item);
            });
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задача 2...");
            Console.Write("Введите размер массива: ");
            int elCount = int.Parse(Console.ReadLine());
            ExecuteThirdTask(elCount);
        }
    }
}
