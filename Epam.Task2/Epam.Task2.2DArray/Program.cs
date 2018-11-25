using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = 3;
            int[,] array = new int[lenght, lenght];
            InitArray(array);
            Console.WriteLine($"Sum = {SumElementOnAEvenPosition(array)}");
        }
        static void InitArray(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-5, 5);
                }
            }
        }
        static int SumElementOnAEvenPosition(int[,] array)
        {
            int sum = 0; 
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += array[i,j];
                    }
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            return sum;
        }
    }
}
