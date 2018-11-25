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
            Console.WriteLine("Введите строку");
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
            Console.WriteLine($"Средняя длина слова = {Math.Round((double)sum / (count + 1))}");
        }
    }
}
