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
            try
            {
                CreateString(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void CreateString(string str)
        {
            uint number;
            if (!uint.TryParse(str, out number) || number==0)
            {
                throw new Exception("Incorrect number");
            }
            else
            {
                for (uint i = 1; i < number; i++)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine(number);
            }
        }
    }
}
