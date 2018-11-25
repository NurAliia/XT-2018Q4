using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter two sides of rectangle \n Between \"Enter\"");
                string strA = Console.ReadLine(),
                       strB = Console.ReadLine();
                try
                {
                    if (SquareRectangle(strA, strB))
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
        }
        static bool SquareRectangle(string strA, string strB)
        {
            bool aConvert = int.TryParse(strA, out var a);
            bool bConvert = int.TryParse(strB, out var b);

            if (aConvert && bConvert)
            {
                if (a > 0 && b > 0)
                {
                    Console.WriteLine($"Square = {a * b}");
                    return true;
                }
                else
                {
                    throw new Exception("Incorrect number");
                }
            }
            return false;
        }
    }
}
