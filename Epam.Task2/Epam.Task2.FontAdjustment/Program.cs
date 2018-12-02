using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.FontAdjustment
{
    [Flags]
    public enum Font
    {
        None = 0x0, 
        Bold = 0x1,
        Italic = 0x2,
        UnderLine = 0x4
    }
    class Program
    {
        static void Main(string[] args)
        {
            Font font = new Font();
            while (true)
            {
                Console.Write("Parameters the  inscription: ");
                Check(font);
                Console.WriteLine($"Enter {Environment.NewLine} 1:bold {Environment.NewLine} 2:italic {Environment.NewLine} 3:underline");
                if (int.TryParse(Console.ReadLine(), out var digit))
                {
                    if (digit == 3)
                    {
                        digit = 4;
                    }
                    font ^= (Font)digit;                   
                }
                else
                {
                    Console.WriteLine("Incorrect number");
                }
            }
        }
        static void Check(Font font)
        {
            // Switch on the flags.
            switch (font)
            {
                case Font.Bold | Font.Italic | Font.UnderLine:
                    {
                        Console.WriteLine("Bold, Italic, UnderLine");
                        break;
                    }
                case Font.Bold | Font.Italic:
                    {
                        Console.WriteLine("Bold, Italic");
                        break;
                    }
                case Font.Bold | Font.UnderLine:
                    {
                        Console.WriteLine("Bold, UnderLine");
                        break;
                    }
                case Font.Bold:
                    {
                        Console.WriteLine("Bold");
                        break;
                    }
                case Font.Italic | Font.UnderLine:
                    {
                        Console.WriteLine("Italic, UnderLine");
                        break;
                    }
                case Font.None:
                    {
                        Console.WriteLine("None");
                        break;
                    }
            }
        }

    }
}
