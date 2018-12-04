// <copyright file="Program.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Employee
{
    using System;

    /// <summary>
    ///  This class performs a main function.  
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Create object Employee
        /// </summary>
        public static void Main()
        {
            try
            {
                DateTime dOB = new DateTime(1998, 2, 12);
                Employee emp = new Employee("ivan", "ivanov", "ivanovich", dOB, "crew member", 2);
                Console.WriteLine(emp.ToString());
                emp.Position = "manager";
                Console.WriteLine(emp.ToString());
                emp.Position = "12312";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
