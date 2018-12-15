// <copyright file="ExtensionString.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task5.ToIntOrNotToInt
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    ///  This class performs a work with machine (automate).
    /// </summary>
    public static class ExtensionString
    {
        /// <summary>
        /// Check string
        /// </summary>
        /// <param name="str">Current string</param>
        /// <param name="func">Current delegate</param>
        /// <returns>is it a positive integer number</returns>
        public static bool UintParse(this string str, Func<string, Automate, bool> func)
        {
            Automate automate = new Automate();
            return func(str, automate);
        }

        /// <summary>
        /// Check stringBuilder
        /// </summary>
        /// <param name="str">Current string</param>
        /// <param name="func">Current delegate</param>
        /// <returns>is it a positive integer number</returns>
        public static bool UintParse(this StringBuilder str, Func<string, Automate, bool> func)
        {
            Automate automate = new Automate();
            return func(str.ToString(), automate);
        }

        /// <summary>
        /// Parse to a positive integer
        /// </summary>
        /// <param name="str">Current string</param>
        /// <param name="automate">Current automate</param>
        /// <returns>is it a positive integer number</returns>
        public static bool ParseToUint(string str, Automate automate)
        {
            HashSet<int> currentSet = new HashSet<int>(automate.StartStates);
            HashSet<int> temp = currentSet;
            int countDigitAfterCommas = 0;
            int numberAfterEps = 0;
            for (int i = 0; i < str.Length; i++)
            {
                temp = new HashSet<int>();
                if (automate.Alphabet.Contains(str[i]))
                {
                    int j = Array.IndexOf(automate.Alphabet, str[i]);
                    foreach (var currentState in currentSet)
                    {
                        if (automate.Table[currentState][j] == -1)
                        {
                            return false;
                        }

                        temp.Add(automate.Table[currentState][j]);

                        if (str[i] == '.' || str[i] == ',')
                        {
                            countDigitAfterCommas = i;
                        }

                        if (str[i] == 'E' || str[i] == 'e')
                        {
                            countDigitAfterCommas = i - countDigitAfterCommas - 1;
                        }

                        if (str[i] != '+' && str[i] != '-' && (currentState == 6 || currentState == 7 || currentState == 8 || currentState == 9))
                        {
                            numberAfterEps += str[i] & 0x0f;
                        }
                    }

                    currentSet = temp;
                }
                else
                {
                    return false;
                }
            }

            if (automate.FinishStates.Contains(temp.ElementAt(0)))
            {
                if (numberAfterEps ==0 && countDigitAfterCommas == 0)
                {
                    return true;
                }
                else if (numberAfterEps > countDigitAfterCommas && str.Contains('+'))
                {
                    return true;
                }                
                else if (numberAfterEps <= countDigitAfterCommas)
                {
                    int item = str.IndexOf('E') == -1 ? str.IndexOf('e') : str.IndexOf('E');
                    while (str[--item].CompareTo('0') == 0)
                    {
                        countDigitAfterCommas--;
                    }

                    if (numberAfterEps > countDigitAfterCommas)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
