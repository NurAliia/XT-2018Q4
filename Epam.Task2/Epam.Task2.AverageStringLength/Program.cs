using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.AverageStringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            int sum = 0, count = 0;
            foreach (var c in text)
            {
                if (Char.IsSeparator(c) && sum != 0)
                {
                    count++;
                }
                else if (Char.IsLetter(c))
                {
                    sum++;
                }
            }
            Console.WriteLine($"Average length of word  = {Math.Round((double)sum / (count + 1))}");
        }
    }
}
