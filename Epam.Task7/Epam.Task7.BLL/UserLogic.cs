// <copyright file="UserLogic.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.BLL
{
    using System;
    using System.Collections.Generic;
    using Epam.Task7.BLL.Interface;
    using Epam.Task7.DAL.Interface;
    using Epam.Task7.Entities;

    /// <summary>  
    ///  This class describes a UserLogic.
    /// </summary>  
    public class UserLogic : IUserLogic
    {
        /// <summary>
        /// Declare variable ALL_USERS_CACHE_KEY
        /// </summary>
        private const string ALLUSERSCACHEKEY = "GetAllUsers";

        /// <summary>
        /// Declare variable _userDao
        /// </summary>
        private readonly IUserDao userDao;

        /// <summary>
        /// Declare variable _cacheLogic
        /// </summary>
        private readonly ICacheLogic cacheLogic;

        /// <summary>
        ///  Initializes a new instance of the <see cref="UserLogic" /> class
        /// </summary>  
        /// <param name="userDao">user Dao</param>
        /// <param name="cacheLogic">cache logic</param>
        public UserLogic(IUserDao userDao, ICacheLogic cacheLogic)
        {
            this.userDao = userDao;
            this.cacheLogic = cacheLogic;
        }

        /// <summary>
        /// Add new user
        /// </summary>
        /// <param name="user">New user</param>
        public void Add(User user)
        {
            try
            {
                if (user == null)
                {
                    throw new Exception("User is null");
                }

                this.cacheLogic.Delete(ALLUSERSCACHEKEY);
                this.userDao.Add(user);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="id">user id</param>
        public void Delete(int id)
        {
            this.userDao.Delete(id);
        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="user">Current user</param>
        public void Update(User user)
        {
            this.userDao.Update(user);
        }

        /// <summary>
        /// Get by id user
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>Current user</returns>
        public User GetById(int id)
        {
            return this.userDao.GetById(id);
        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns>collection or users</returns>
        public IEnumerable<User> GetAll()
        {
            var cacheResult = this.cacheLogic.Get<IEnumerable<User>>(ALLUSERSCACHEKEY);

            if (cacheResult == null)
            {
                var result = this.userDao.GetAll();
                this.cacheLogic.Add(ALLUSERSCACHEKEY, this.userDao.GetAll());
                Console.WriteLine("From dao");
                return result;
            }

            Console.WriteLine("From cache");
            return cacheResult;
        }

        /// <summary>
        /// Terminate work with users into file
        /// </summary>
        public void Terminate()
        {
            this.userDao.Terminate();
        }
    }
}
