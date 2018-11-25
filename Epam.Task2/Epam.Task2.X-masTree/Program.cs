using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.X_masTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of triangle");
            try
            {
                DrawTree(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void DrawTree(string str)
        {
            if (!uint.TryParse(str, out var n) || str.Equals("0"))
            {
                throw new Exception("Incorrect count of triangle");
            }
            else
            {
                for (int t = 1; t <= n; t++)
                {
                    var start = ((n * 2) - 1) / 2;
                    for (var i = 0; i < t; i++)
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
}
