using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive odd number");
            try
            {
                PrintSquareFirst(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void PrintSquareFirst(string str)
        {
            uint number;
            if (!uint.TryParse(str, out number) || number % 2 == 0)
            {
                throw new Exception("Incorrect number");
            }
            else
            {
                uint middle = number / 2;
                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write(i == middle && j == middle ? ' ' : '*');
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
