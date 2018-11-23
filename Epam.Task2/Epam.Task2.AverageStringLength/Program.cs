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
            string text = Console.ReadLine();
            Console.WriteLine(text);
            int sum = 0, count = 0;
            char[] separeters = { ' ', ',', '!', '.', '?','0','1','2','3','4','5','6','7','8','9'};
            foreach (var word in text.Split(separeters))
            {
                if (word.Length!=0)
                {
                    sum += word.Length;
                    count++;
                }
            }
            Console.WriteLine($"Average lenght is {Math.Round((double)sum / count)}");
        }
    }
}
