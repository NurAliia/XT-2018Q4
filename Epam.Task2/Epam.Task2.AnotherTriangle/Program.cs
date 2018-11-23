using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AnotherTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of string");
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
            if (!uint.TryParse(str, out var n) || str.Equals("0"))
            {
                throw new Exception("Incorrect count of string");
            }
            else
            {
                var start = ((n * 2) - 1) / 2;
                for (var i = 0; i < n; i++)
                {
                    var j = 0;
                    for (j = 0; j < start; j++)
                    {
                        Console.Write(' ');
                    }
                    for (j = 0; j <= i * 2; j++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                    start--;
                }
            }
        }
    }
}
