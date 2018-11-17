using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive odd number");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number % 2 == 0)
            {
                Console.WriteLine("Incorrect number");
            }
            else
            {
                PrintSquareFirst(number);
                Console.WriteLine("////////////");
                PrintSquareSecond(number);
            }
        }
        static void PrintSquareFirst(int number)
        {
            int middle = number / 2;
            for (int i = 0; i < number; i++)
            {
                if (i == middle)
                {
                    for (int j = 0; j < number; j++)
                    {
                        if (j == middle)
                        {
                            Console.Write(' ');
                        }
                        else
                        {
                            Console.Write('*');
                        }

                    }
                }
                else
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }
        }
        static void PrintSquareSecond(int number)
        {
            StringBuilder stringSimple = new StringBuilder();
            stringSimple.Append('*',(int)number);
            int middle = number / 2;
            for (int i = 0; i < number; i++)
            {
                if (i != middle)
                {
                    Console.WriteLine(stringSimple);
                }
                else
                {
                    StringBuilder stringNotSimple = new StringBuilder();
                    stringNotSimple.Append('*',middle);
                    stringNotSimple.Append(' ',1);
                    stringNotSimple.Append('*', middle);
                    Console.WriteLine(stringNotSimple);
                }
            }
        }
    }
}
