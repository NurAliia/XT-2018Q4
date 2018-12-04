// <copyright file="MyString.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.MyString
{
    using System.Linq;
    using System.Text;

    /// <summary>  
    ///  This class describes a MyString.
    /// </summary>  
    public class MyString
    {
        /// <summary>
        /// Declare variable massiveChar
        /// </summary>
        private char[] massiveChar;

        /// <summary>
        /// Initializes a new instance of the MyString class.
        /// </summary>
        /// <param name="mas">Array of chars</param>
        public MyString(params char[] mas)
        {
            this.massiveChar = mas;
        }

        /// <summary>
        /// Indexer of MyString
        /// </summary>
        /// <param name="index">position in the MyString</param>
        /// <returns>char from this position</returns>
        public char this[int index]
        {
            get
            {
                return this.massiveChar[index];
            }

            set
            {
                this.massiveChar[index] = value;
            }
        }

        /// <summary>
        /// implicit type conversion from MyString to string
        /// </summary>        
        /// <param name='str'>string will be need to be validated</param>>
        /// <returns>validate or no</returns>
        public static implicit operator string(MyString str)
        {
            return new string(str.massiveChar);
        }

        /// <summary>
        /// implicit type conversion from string to MyString
        /// </summary>        
        /// <param name='str'>string will be need to be validated</param>>
        /// <returns>validate or no</returns>
        public static implicit operator MyString(string str)
        {
            return new MyString(str.ToArray());
        }

        /// <summary>
        /// implicit type conversion from MyString to StringBuilder
        /// </summary>
        /// <param name='str'>string will be need to be validated</param>>
        /// <returns>validate or no</returns>
        public static implicit operator StringBuilder(MyString str)
        {
            return new StringBuilder(new string(str.massiveChar));
        }

        /// <summary>
        /// implicit type conversion from StringBuilder to MyString
        /// </summary>        
        /// <param name='str'>string will be need to be validated</param>>
        /// <returns>validate or no</returns>
        public static implicit operator MyString(StringBuilder str)
        {
            char[] mas = new char[str.Length];
            str.CopyTo(0, mas, 0, str.Length);
            return new MyString(mas);
        }

        /// <summary>
        /// Equals string
        /// </summary>        
        /// <param name='str'>Another string</param>>
        /// <returns>equals or no</returns>
        public bool Equals(MyString str)
        {
            if (this.massiveChar.Equals(str.massiveChar))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// ConCat MyString with another string
        /// </summary>
        /// <param name="str">another string</param>
        /// <returns>new MyString</returns>
        public MyString ConCat(MyString str)
        {
            MyString result = new MyString(this.massiveChar.Concat(str.massiveChar).ToArray());
            return result;
        }

        /// <summary>
        /// SearchChar in massive char
        /// </summary>
        /// <param name="a">search this char</param>
        /// <returns>index of char</returns>
        public int SearchChar(char a)
        {
            if (this.massiveChar.Contains(a))
            {
                for (int i = 0; i < this.massiveChar.Length; i++)
                {
                    if (this.massiveChar[i] == a)
                    {
                        return i;
                    }
                }

                return -1;
            }

            return -1;
        }

        /// <summary>
        /// override ToString()
        /// </summary>
        /// <returns>info about MyString</returns>
        public override string ToString()
        {
            return new string(this.massiveChar);
        }
    }
}
