// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.MyString
{
    using System;
    using System.Text;

    /// <summary>  
    ///  This class performs a main function.  
    /// </summary>  
    public class Program
    {
        /// <summary>
        /// Create object MyString
        /// </summary>
        public static void Main()
        {
            MyString myStr = new MyString('a', 'b', 'c');
            MyString myStr2 = new MyString(new char[] { '2', '3', '4', '5' });
            Console.WriteLine($"MySting = {myStr.ToString()}");
            Console.WriteLine($"MyString2 = {myStr2.ToString()}");
            Console.WriteLine("Equals? = " + myStr.Equals(myStr2));
            Console.WriteLine("Concat = " + myStr.ConCat(myStr2));
            Console.WriteLine("Seach char, index  = " + myStr.SearchChar('a'));

            Console.WriteLine($"Checking index before = {myStr[0]}");
            myStr[0] = '%';
            Console.WriteLine($"Checking index after = {myStr[0]}");

            string str1 = "1234567890";
            myStr = str1;
            Console.WriteLine($"Checking string {str1} - > MyString {myStr.ToString()}");
            myStr[0] = 'a';
            str1 = myStr;
            Console.WriteLine($"Checking MyString  {myStr.ToString()}  - > string {str1}");

            StringBuilder str2 = new StringBuilder();
            str2.AppendFormat("qwerty", 0);
            myStr = str2;
            Console.WriteLine($"Checking StringBuilder {str2} - > MyString {myStr.ToString()}");
            myStr[0] = '1';
            str2 = myStr;
            Console.WriteLine($"Checking  MyString {myStr.ToString()} - > StringBuilder {str2}");
        }
    }
}
