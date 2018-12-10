// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task4.WordFrequency
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>  
    ///  This class performs a main function.  
    /// </summary>  
    public class Program
    {
        /// <summary>
        /// Word with text
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter a text");
            var text = new StringBuilder(Console.ReadLine().ToLower() + " ");
            var dictionary = CountWords(text);
            Console.WriteLine("word : count");
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }

        /// <summary>
        /// Create object User
        /// </summary>
        /// <param name="text">New text</param>
        /// <returns>Dictionary consists of words and frequency</returns>
        public static Dictionary<string, int> CountWords(StringBuilder text)
        {
            var dictionary = new Dictionary<string, int>();
            int k = 0;
            for (int i = 0; i < text.Length;)
            {
                var l = char.IsSeparator(text[i]);
                if (!char.IsLetter(text[i]))
                {
                    if (text[i] == ' ' || text[i] == '.')
                    {
                        var subString = text.SubString(k, i).ToString();
                        if (dictionary.ContainsKey(subString))
                        {
                            dictionary[subString]++;
                        }
                        else if (!string.IsNullOrEmpty(subString))
                        {
                            dictionary.Add(subString, 1);
                        }

                        i++;
                        k = i;
                    }
                    else
                    {
                        text = text.Remove(i, 1);
                    }
                }
                else
                {
                    i++;
                }
            }

            return dictionary;
        }
    }
}
