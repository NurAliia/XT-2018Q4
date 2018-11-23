using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.ArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(2,10);
            }
            Console.WriteLine($"Max {MaxElement(array)}");
            Console.WriteLine($"Min {MinElement(array)}");
            InsertionSort(array);
            Print(array);            
        }
        static private int MaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static private int MinElement(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static private void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j;
                int buf = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buf)
                        break;

                    array[j + 1] = array[j];
                }
                array[j + 1] = buf;
            }
        }
        static private void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
