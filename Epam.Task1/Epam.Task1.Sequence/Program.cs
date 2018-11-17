using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
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
                Console.WriteLine(CreateString(number));
            }
        }
        static StringBuilder CreateString(uint number)
        {
            StringBuilder result = new StringBuilder();
            for (uint i = 1; i < number; i++)
            {
                result.Append(i + ", ");
            }
            result.Append(number);
            return result;
        }
    }
}
