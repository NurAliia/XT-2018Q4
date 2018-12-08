// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.User23
{
    using System;

    /// <summary>  
    ///  This class performs a main function.  
    /// </summary>  
    public class Program
    {
        /// <summary>
        /// Create object User
        /// </summary>
        public static void Main()
        {
            try
            {
                DateTime dayOfBirth = new DateTime(1997, 12, 24);
                User user = new User("НурАлия", "Батталова", "Илдаровна", dayOfBirth);
                Console.WriteLine(user.ToString());

                user.Age = 10;
                Console.WriteLine(user.ToString());

                dayOfBirth = new DateTime(2020, 12, 24);
                user.DateOfBirth = dayOfBirth; // Exception
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
