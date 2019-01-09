// <copyright file="IUserLogic.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.BLL.Interface
{
    using System.Collections.Generic;
    using Epam.Task7.Entities;

    /// <summary>  
    ///  This class describes a IUserLogic.
    /// </summary>  
    public interface IUserLogic
    {
        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="user">New user</param>
        void Add(User user);

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="id">user id</param>
        void Delete(int id);

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="user">Current user</param>
        void Update(User user);

        /// <summary>
        /// Get by id user
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>Current user</returns>
        User GetById(int id);

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns>collection or users</returns>
        IEnumerable<User> GetAll();

        /// <summary>
        /// Terminate work with users into file
        /// </summary>
        void Terminate();
    }
}
