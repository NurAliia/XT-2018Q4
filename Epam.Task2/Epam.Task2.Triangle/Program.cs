using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            try
            {
                DrawTriangle(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void DrawTriangle(string str)
        {
            if (uint.TryParse(str,out var n) && !str.Equals("0"))
            {
                for (var i = 0; i < n; i++)
                {
                    for (var j = 0; j <= i; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                throw new Exception("Incorrent number");
            }
        }
    }
}
