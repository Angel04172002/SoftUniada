using System;
using System.Linq;

namespace SortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            array = SortArray(array);
       
            PrintArray(array);
        }

        static int[] SortArray(int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (array[i] < array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                else
                {
                    if (array[i] > array[i+1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
