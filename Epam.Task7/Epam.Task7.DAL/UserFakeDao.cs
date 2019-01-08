// <copyright file="UserFakeDao.cs" company="Epam">
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
    ///  This class describes a UserFakeDao.
    /// </summary>  
    public class UserFakeDao : IUserDao
    {
        /// <summary>
        /// Declare variable repo users
        /// </summary>
        private static readonly Dictionary<int, User> REPOUSERS = new Dictionary<int, User>();

        /// <summary>
        ///  Initializes a new instance of the <see cref="UserFakeDao" /> class
        /// </summary>  
        public UserFakeDao()
        {
            using (StreamReader sr = new StreamReader(@".\Users.txt", System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var user = line.Split('|');
                    var newUser = new User();
                    newUser.Id = int.Parse(user[0]);
                    newUser.Name = user[1];
                    newUser.LastName = user[2];
                    newUser.DateOfBirth = DateTime.Parse(user[3]);
                    REPOUSERS.Add(int.Parse(user[0]), newUser);
                }
            }
        }

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
        /// Save users into file
        /// </summary>
        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(@".\Users.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item in REPOUSERS)
                {
                    sw.WriteLine(item.Value.ToStringForFile());
                }
            }
        }
    }
}
