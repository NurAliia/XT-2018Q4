// <copyright file="DependencyResolver.cs" company="Epam">
//     Copyright Epam. All rights reserved 
// </copyright>

namespace Epam.Task7.Common
{
    using System.Configuration;
    using Epam.Task7.BLL;
    using Epam.Task7.BLL.Interface;
    using Epam.Task7.DAL;
    using Epam.Task7.DAL.Interface;

    /// <summary>  
    ///  This class describes a DependencyResolver.
    /// </summary>  
    public static class DependencyResolver
    {
        /// <summary>
        /// Declare variable userDao
        /// </summary>
        private static IUserDao userDao;

        /// <summary>
        /// Declare variable awardDao
        /// </summary>
        private static IAwardDao awardDao;

        /// <summary>
        /// Declare variable userLogic
        /// </summary>
        private static IUserLogic userLogic;

        /// <summary>
        /// Declare variable cacheLogic
        /// </summary>
        private static ICacheLogic cacheLogic;

        /// <summary>
        /// Declare variable awardLogic
        /// </summary>
        private static IAwardLogic awardLogic;

        /// <summary>
        /// Gets userDao of the UserDao.
        /// </summary>
        public static IUserDao UserDao
        {
            get
            {
                var key = ConfigurationManager.AppSettings["DaoUserKey"];

                if (userDao == null)
                {
                    switch (key.ToLower())
                    {
                        case "memory":
                            {
                                userDao = new UserFakeDao();
                                break;
                            }

                        case "textfiles":
                            {
                                userDao = new UserFakeDao();
                                break;
                            }

                        default:
                            break;
                    }
                }

                return userDao;
            }
        }

        /// <summary>
        /// Gets awardDao of the AwardDao.
        /// </summary>
        public static IAwardDao AwardDao
        {
            get
            {
                var key = ConfigurationManager.AppSettings["DaoAwardKey"];

                if (awardDao == null)
                {
                    switch (key.ToLower())
                    {
                        case "memory":
                            {
                                awardDao = new AwardFakeDao();
                                break;
                            }

                        case "textfiles":
                            {
                                awardDao = new AwardFakeDao();
                                break;
                            }

                        default:
                            break;
                    }
                }

                return awardDao;
            }
        }

        /// <summary>
        /// Gets _userLogic of the UserLogic.
        /// </summary>
        public static IUserLogic UserLogic => userLogic ?? (userLogic = new UserLogic(UserDao, CacheLogic));

        /// <summary>
        /// Gets _cacheLogic of the UserLogic.
        /// </summary>
        public static ICacheLogic CacheLogic => cacheLogic ?? (cacheLogic = new CacheLogic());

        /// <summary>
        /// Gets _awardLogic of the UserLogic.
        /// </summary>
        public static IAwardLogic AwardLogic => awardLogic ?? (awardLogic = new AwardLogic(AwardDao, CacheLogic));
    }
}
