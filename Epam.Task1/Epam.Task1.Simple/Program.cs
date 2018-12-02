using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number");
            uint number;
            if (!uint.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect number");
            }
            else
            {
                Console.WriteLine(CheckNumber(number) ? "Simple" : "Composite");
            }            
        }
        static bool CheckNumber(uint number)
        {
            int sqrtNumber = (int)Math.Sqrt(number);
            for (int i = 2; i < sqrtNumber; i++)
            {
                if (number % i == 0)
                {
                   return false;
                }
            }
            return true;
        }
    }
}
