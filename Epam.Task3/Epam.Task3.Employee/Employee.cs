// <copyright file="Employee.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task3.Employee
{
    using System;
    using Epam.Task3.User23;

    /// <summary>  
    ///  This class describes a Employee.
    /// </summary>  
    public class Employee : User
    {
        /// <summary>
        /// Declare variable work experience
        /// </summary>
        private int workExperience;

        /// <summary>
        /// Declare variable position
        /// </summary>
        private string position;

        /// <summary>
        /// Initializes a new instance of the Employee class.
        /// </summary>
        public Employee()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Employee class.
        /// </summary>
        /// <param name="name">User name</param>
        /// <param name="lastName">User lastName</param>
        /// <param name="patronymic">User patronymic</param>
        /// <param name="dayOfBirth">User date Of Birth</param>
        /// <param name="position">The position of the Employee</param>
        /// <param name="workExperience">The work experience of the Employee</param>
        public Employee(string name, string lastName, string patronymic, DateTime dayOfBirth, string position, int workExperience) : base(name, lastName, patronymic, dayOfBirth)
        {
            this.Position = position;
            this.WorkExperience = workExperience;
        }

        /// <summary>
        /// Gets or sets work experience of the Employee.
        /// </summary>
        public int WorkExperience
        {
            get
            {
                return this.workExperience;
            }

            set
            {
                if (value >= 0)
                {
                    this.workExperience = value;
                }
                else
                {
                    throw new ArgumentException("Incorrent work experience value");
                }
            }
        }

        /// <summary>
        /// Gets or sets Position of the Employee.
        /// </summary>
        public string Position
        {
            get
            {
                return this.position;
            }

            set
            {
                if (this.ValidateString(value))
                {
                    this.position = value;
                }
                else
                {
                    throw new ArgumentException("Incorrent position");
                }
            }
        }

        /// <summary>
        /// new ToString()
        /// </summary>
        /// <returns>info about MyString</returns>
        public new string ToString()
        {
            return $"{Name} {LastName} {Patronymic} {DateOfBirth.ToShortDateString()} {Age} {Position} {WorkExperience}";
        }
    }
}
