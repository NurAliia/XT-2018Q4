using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Non_NegativeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            InitArray(array);
            Print(array);
            Console.WriteLine($"Sum = {NonNegativeSum(array)}");
        }
        static void InitArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = random.Next(-10, 10);
            }
        }
        static int NonNegativeSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        static void Print(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
