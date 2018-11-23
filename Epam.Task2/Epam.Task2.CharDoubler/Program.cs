using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.CharDoubler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку:");
            StringBuilder first = new StringBuilder(Console.ReadLine());
            Console.Write("Введите вторую строку:");
            StringBuilder second = new StringBuilder(Console.ReadLine());
            foreach (var c in second.ToString())
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (c == first[i])
                    {
                        first.Insert(i, c.ToString());
                        i++;
                    }
                }
                //Remove another the same chars 
                while (second.ToString().Contains(c))
                {
                    second.Remove(second.ToString().IndexOf(c), 1);
                }
                if (second.Length == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Результирующая строка:{first}");
        }
        static string NewSecondString(string str)
        {
            string newStr = "";
            foreach (var c in str)
            {
                if (!newStr.Contains(c))
                {
                    newStr += c;
                }
            }
            return str;
        }
    }
}
