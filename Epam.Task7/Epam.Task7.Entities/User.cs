// <copyright file="User.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.Entities
{
    using System;

    /// <summary>  
    ///  This class describes a User.
    /// </summary>  
    public class User
    {
        /// <summary>
        /// Declare variable name
        /// </summary>
        private string name;

        /// <summary>
        /// Declare variable lastName
        /// </summary>
        private string lastName;

        /// <summary>
        /// Declare variable dateOfBirth
        /// </summary>
        private DateTime dateOfBirth;

        /// <summary>
        /// Declare variable age
        /// </summary>
        private int age = 0;

        /// <summary>
        ///  Initializes a new instance of the <see cref="User" /> class
        /// </summary>  
        public User()
        {
        }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        /// <param name="id">User id</param>
        /// <param name="name">User name</param>
        /// <param name="lastName">User lastName</param>
        /// <param name="d">User date Of Birth</param>
        public User(int id, string name, string lastName, DateTime d)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.DateOfBirth = d;
        }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        /// <param name="name">User name</param>
        /// <param name="lastName">User lastName</param>
        /// <param name="d">User date Of Birth</param>
        public User(string name, string lastName, DateTime d)
        {
            this.Name = name;
            this.LastName = lastName;
            this.DateOfBirth = d;
        }

        /// <summary>
        /// Gets or sets Id of the User.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Name of the User.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.ValidateString(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect name");
                }
            }
        }

        /// <summary>
        /// Gets or sets LastName of the User.
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (this.ValidateString(value))
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect lastName");
                }
            }
        }

        /// <summary>
        /// Gets or sets DateOfBirth of the User.
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                DateTime currentDate = DateTime.Now;
                int currentAge = currentDate.Year - value.Year;
                if (value < currentDate && currentAge < 150)
                {
                    this.dateOfBirth = value;
                    this.age = currentAge;
                }
                else
                {
                    throw new ArgumentException("Incorrect date of birthday");
                }
            }
        }

        /// <summary>
        /// Gets or sets Age of the User.
        /// </summary>
        public int Age
        {
            get
            {
                if (this.age == 0)
                {
                    DateTime dt = DateTime.Now;
                    this.age = dt.Day < this.DateOfBirth.Day ? (dt.Year - this.DateOfBirth.Year) - 1 : (DateTime.Now.Year - this.DateOfBirth.Year);
                }

                return this.age;
            }

            set
            {
                if (value >= 0 && value < 150)
                {
                    this.age = value;
                    this.dateOfBirth = new DateTime(DateTime.Now.Year - this.age, this.dateOfBirth.Month, this.dateOfBirth.Day);
                }
                else
                {
                    throw new ArgumentException("Incorrect age");
                }
            }
        }

        /// <summary>
        /// New ToString()
        /// </summary>
        /// <returns>Info about user string</returns>
        public new string ToString()
        {
            return $"{this.Name} {this.LastName} {this.DateOfBirth.ToShortDateString()} {this.Age}";
        }

        /// <summary>
        /// For File ToString()
        /// </summary>        
        /// <returns>Info about user string</returns>
        public string ToStringForFile()
        {
            return $"{this.Id}|{this.Name}|{this.LastName}|{this.DateOfBirth.ToShortDateString()}|{this.Age}";
        }

        /// <summary>
        /// Validate String
        /// </summary>        
        /// <param name='validateString'>string will be need to be validated</param>>
        /// <returns>validate or no</returns>
        protected bool ValidateString(string validateString)
        {
            if (!string.IsNullOrWhiteSpace(validateString))
            {
                char[] arrayOfString = validateString.ToCharArray();
                foreach (char symbol in arrayOfString)
                {
                    if (!char.IsWhiteSpace(symbol) && !char.IsLetter(symbol))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}
