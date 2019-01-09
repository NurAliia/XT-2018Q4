// <copyright file="UserMemoryDao.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.DAL
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Epam.Task7.DAL.Interface;
    using Epam.Task7.Entities;

    /// <summary>  
    ///  This class describes a UserMemoryDao.
    /// </summary>  
    public class UserMemoryDao : IUserDao
    {
        /// <summary>
        /// Declare variable repo users
        /// </summary>
        private static readonly Dictionary<int, User> REPOUSERS = new Dictionary<int, User>();

        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="user">New user</param>
        public void Add(User user)
        {
            var lastId = REPOUSERS.Any()
                ? REPOUSERS.Keys.Max()
                : 0;
            user.Id = ++lastId;
            REPOUSERS.Add(user.Id, user);
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>successfully or no</returns>
        public bool Delete(int id)
        {
            return REPOUSERS.Remove(id);
        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="user">Current user</param>
        /// <returns>successfully or no</returns>
        public bool Update(User user)
        {
            if (!REPOUSERS.ContainsKey(user.Id))
            {
                return false;
            }

            REPOUSERS[user.Id] = user;
            return true;
        }

        /// <summary>
        /// Get by id user
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>Current user</returns>
        public User GetById(int id)
        {
            return REPOUSERS.TryGetValue(id, out var user)
                ? user
                : null;
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns>collection or users</returns>
        public IEnumerable<User> GetAll()
        {
            return REPOUSERS.Values;
        }

        /// <summary>
        /// Terminate users into file
        /// </summary>
        public void Terminate()
        {
        }
    }
}
